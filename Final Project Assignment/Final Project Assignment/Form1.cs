using System.Text;

namespace Final_Project_Assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV (*.csv) | *.csv";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string[] readAllLine = File.ReadAllLines(openFileDialog.FileName);

                string readAllText = File.ReadAllText(openFileDialog.FileName);
                for (int i = 0; i < readAllLine.Length; i++)
                {
                    string allDATARAW = readAllLine[i];
                    string[] allDATASplited = allDATARAW.Split(',');
                    this.dataGridView1.Rows.Add(allDATASplited[0], allDATASplited[1], allDATASplited[2], allDATASplited[3], allDATASplited[4], allDATASplited[5], allDATASplited[6]);
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "CSV(*.csv)|*.csv";
                bool fileError = false;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (!fileError)
                    {
                        try
                        {
                            int columnCount = dataGridView1.Columns.Count;
                            string column = "";
                            string[] outputCSV = new string[dataGridView1.Rows.Count + 1];
                            for (int i = 0; i < columnCount; i++)
                            {
                                column += dataGridView1.Columns[i].HeaderText.ToString() + ",";
                            }
                            outputCSV[0] += column;
                            for (int i = 1; (i - 1) < dataGridView1.Rows.Count; i++)
                            {
                                for (int j = 0; j < columnCount; j++)
                                {
                                    outputCSV[i] += dataGridView1.Rows[i - 1].Cells[j].Value.ToString() + ",";
                                }
                            }
                            File.WriteAllLines(saveFileDialog.FileName, outputCSV, Encoding.UTF8);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            int size = Convert.ToInt32(textBoxSize.Text);
            int price = Convert.ToInt32(textBoxPrice.Text);
            int sum = size * price;
            textBoxAssess.Text = sum.ToString();

            string Name = textBoxName.Text;
            string Address = textBoxAddress.Text;
            string Type = comboBoxType.Text;
            string Assess = textBoxAssess.Text;

            int n = dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = Name;
            dataGridView1.Rows[n].Cells[1].Value = Address;
            dataGridView1.Rows[n].Cells[2].Value = Type;
            dataGridView1.Rows[n].Cells[3].Value = size;
            dataGridView1.Rows[n].Cells[4].Value = price;
            dataGridView1.Rows[n].Cells[5].Value = Assess;

            if (Type == "ประเภทที่อยู่อาศัย")
            {
                Live live = new Live(); //ประกาศคลาส
                live.addLive(Type, Assess);
                double a = live.getLive(); //รับค่ามาเป็นดับเบิ้ลแล้วใช้ เอเป็นตัวเก็บ
                dataGridView1.Rows[n].Cells[6].Value = a.ToString(); //นำเอมาแสดงที่คอลลัม6
            }
            else if (Type == "ประเภทพาณิชยกรรม")
            {
                Trade trade = new Trade();
                trade.addTrade(Type, Assess);
                double b = trade.getTrade();
                dataGridView1.Rows[n].Cells[6].Value = b.ToString();
            }
            else if (Type == "ประเภทที่ว่างเปล่า")
            {
                Empty empty = new Empty();
                empty.addEmpty(Type, Assess);
                double c = empty.getEmpty();
                dataGridView1.Rows[n].Cells[6].Value = c.ToString();
            }

            //Live live = new Live(); //ประกาศคลาส
            //live.addLive(Type, Assess);
            //double a = live.getLive(); //รับค่ามาเป็นดับเบิ้ลแล้วใช้ เอเป็นตัวเก็บ
            //dataGridView1.Rows[n].Cells[6].Value = a.ToString(); //นำเอมาแสดงที่คอลลัม6

            //Trade trade = new Trade();
            //trade.addTrade(Type, Assess);
            //double b = trade.getTrade();
            //dataGridView1.Rows[n].Cells[6].Value = b.ToString();

            //Empty empty = new Empty();
            //empty.addEmpty(Type, Assess);
            //double c = empty.getEmpty();
            //dataGridView1.Rows[n].Cells[6].Value = c.ToString();


            comboBoxType.Text = null;
            textBoxName.Text = "";
            textBoxPrice.Text = "";
            textBoxAddress.Text = "";
            textBoxAssess.Text = "";
            textBoxSize.Text = "";
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(rowIndex);
        }
    }
}