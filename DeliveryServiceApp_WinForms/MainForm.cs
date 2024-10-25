using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace DeliveryServiceApp_WinForms
{
    public partial class MainForm : Form
    {
        private enum AreaOfTheCity
        {
            Center,
            North,
            West
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            comboBoxAreaOfTheCity.DataSource = Enum.GetValues(typeof(AreaOfTheCity));
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            Filter();
        }

        private void textBoxDeliveryCompletionPeriod_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void Filter()
        {
            if (!ValidateInputs(out DateTime firstDeliveryDateTime, out string district, out string logFilePath, out string resultFilePath, out string ordersFilePath, out int deliveryCompletionPeriodInMinutes))
                return;

            Log(logFilePath, "Программа запущена");

            try
            {
                List<Order> orders = ReadOrders(ordersFilePath);

                List<Order> filteredOrders = FilterOrders(orders, district, firstDeliveryDateTime, deliveryCompletionPeriodInMinutes, checkBoxRegister.Checked);

                WriteOrders(resultFilePath, filteredOrders);

                MessageBox.Show($"Фильтрация успешно завершена.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Log(logFilePath, $"Фильтрация завершена. Найдено {filteredOrders.Count} заказов.\n");
            }
            catch (Exception ex)
            {
                ShowErrorMessage("Ошибка при обработке", ex.Message);
                Log(logFilePath, $"Ошибка: {ex.Message}\n");
            }
        }

        public bool ValidateInputs(out DateTime firstDeliveryDateTime, out string district, out string logFilePath, out string resultFilePath, out string ordersFilePath, out int deliveryPeriod)
        {
            district = comboBoxAreaOfTheCity.Text;
            firstDeliveryDateTime = DateTime.MinValue;
            logFilePath = textBoxLogFilePath.Text;
            resultFilePath = textBoxResultFilePath.Text;
            ordersFilePath = textBoxOrdersFilePath.Text;

            if (!DateTime.TryParseExact(dateTimeTimeOfTheFirstDelivery.Text, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out firstDeliveryDateTime) || string.IsNullOrEmpty(district))
            {
                ShowErrorMessage("Некорректные параметры", "Введите корректные данные для района и времени доставки.");
                deliveryPeriod = 0;
                return false;
            }

            deliveryPeriod = int.TryParse(textBoxDeliveryCompletionPeriod.Text, out int period) ? period : 0;
            if (deliveryPeriod <= 0 || !CheckFileExistence(logFilePath, "логов") || !CheckFileExistence(resultFilePath, "для записи результа") || !CheckFileExistence(ordersFilePath, "входных данных"))
                return false;

            return true;
        }

        private bool CheckFileExistence(string filePath, string fileDescription)
        {
            if (!File.Exists(filePath))
            {
                ShowErrorMessage("Некорректный путь", $"Не найден файл {fileDescription} по указанному пути.");
                return false;
            }
            return true;
        }

        private void ShowErrorMessage(string title, string message)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void WriteOrders(string resultFilePath, List<Order> orders)
        {
            using (var writer = new StreamWriter(resultFilePath))
            {
                foreach (var order in orders)
                {
                    writer.WriteLine($"{order.Id};{order.Weight};{order.District};{order.DeliveryTime:yyyy-MM-dd HH:mm:ss}");
                }
            }
        }

        public static List<Order> FilterOrders(List<Order> orders, string district, DateTime firstOrderDateTime, int deliveryCompletionPeriodInMinutes, bool caseSensitive)
        {
            return orders.Where(o => (caseSensitive ? o.District == district : o.District.Equals(district, StringComparison.CurrentCultureIgnoreCase)) &&
                                     o.DeliveryTime >= firstOrderDateTime &&
                                     o.DeliveryTime <= firstOrderDateTime.AddMinutes(deliveryCompletionPeriodInMinutes)).ToList();
        }

        public static List<Order> ReadOrders(string filePath)
        {

            var orders = new List<Order>();
            var lines = File.ReadAllLines(filePath);

            foreach (var line in lines)
            {
                var parts = line.Split(';');
                var order = new Order
                {
                    Id = int.Parse(parts[0]),
                    Weight = double.Parse(parts[1]),
                    District = parts[2],
                    DeliveryTime = DateTime.ParseExact(parts[3], "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture)
                };

                orders.Add(order);
            }

            return orders;

        }

        private static void Log(string logFilePath, string message)
        {
            using (var sw = new StreamWriter(logFilePath, true))
            {
                sw.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss}: {message}");
            }
        }


    }
}
