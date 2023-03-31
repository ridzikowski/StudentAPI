using System.IO;
using System.Text.Json;
using System.Net.Http;
namespace WinFormsApp1
{
    public partial class StudentAPI : Form
    {
        public StudentAPI()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            //var json = File.ReadAllText(@"students.json");
            string json = await downloadData();
            textBox1.Text = json;
            var students = JsonSerializer.Deserialize<List<Student>>(json);
            listBox1.Items.Clear();
            foreach (var student in students)
                listBox1.Items.Add(student);
        }

        private async Task<string> downloadData() {
            HttpClient client = new HttpClient();
            string call = "http://radoslaw.idzikowski.staff.iiar.pwr.wroc.pl/instruction/students.json";
            string json =  await client.GetStringAsync(call);
            return json;
        }

    }
}