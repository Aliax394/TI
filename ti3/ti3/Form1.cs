using System.IO;

namespace ti3;

public partial class Form1 : Form
{
    readonly RSA rsa = new();
    private int R { get; set; }
    int ElFunc { get; set; }
    int E { get; set; }
    int D { get; set; }
    ushort[] CRes { get; set; }
    byte[] DRes { get; set; }
    byte[] OpenPB { get; set; }
    byte[] OpenCB { get; set; }
    OpenFileDialog openFile = new OpenFileDialog();
    SaveFileDialog saveFile = new SaveFileDialog();
    public Form1()
    {
        InitializeComponent();
        CradioButton.Checked = true;
    }



    private void button1_Click(object sender, EventArgs e)
    {

    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void makebutton_Click(object sender, EventArgs e)
    {
        PtextBox.Text = string.Join("", PtextBox.Text.Where(char.IsDigit));
        QtextBox.Text = string.Join("", QtextBox.Text.Where(char.IsDigit));
        DtextBox.Text = string.Join("", DtextBox.Text.Where(char.IsDigit));
        if (PtextBox.Text.Length == 0)
        {
            MessageBox.Show("Введите P");
            return;
        }
        if (QtextBox.Text.Length == 0)
        {
            MessageBox.Show("Введите Q");
            return;
        }
        int p = 0;
        int q = 0;
        try
        {
            p = int.Parse(PtextBox.Text);
            if (!RSA.IsPrime(p))
            {
                MessageBox.Show("P не является простым!");
                return;
            }
            q = int.Parse(QtextBox.Text);
            if (!RSA.IsPrime(q))
            {
                MessageBox.Show("Q не является простым!");
                return;
            }
        }
        catch
        {
            MessageBox.Show("Некорректный диапазон");
            return;
        }
        R = p * q;
        if (R is < 256 or > ushort.MaxValue)
        {
            MessageBox.Show($"Ваше произведение P и Q должно быть не меньше 256 и не больше {ushort.MaxValue}");
            return;
        }
        RtextBox.Text = R.ToString();
        ElFunc = RSA.EulerPhi(R);
        FtextBox.Text = ElFunc.ToString();
        if (DtextBox.Text.Length == 0)
        {
            MessageBox.Show("Введите D");
            return;
        }
        D = int.Parse(DtextBox.Text);
        if (D <= 1 || D > ElFunc)
        {
            MessageBox.Show("D меньше 1 или больше функции эйлера!");
            return;
        }
        int gsd = RSA.FindGcd(D, ElFunc);
        if (gsd != 1)
        {
            MessageBox.Show("E не взаимно простая с функцией Эйлера!", "Внимание");
            return;
        }
        var extEuclRes = RSA.ExteEuclid(ElFunc, D);
        E = extEuclRes.y;
        EtextBox.Text = E.ToString();

    }

    private void CradioButton_CheckedChanged(object sender, EventArgs e)
    {
        resbutton.Text = "зашифровать";
    }

    private void openToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (openFile.ShowDialog() != DialogResult.Cancel)
        {
            OpenPB = File.ReadAllBytes(openFile.FileName);
            textBox1.Text = string.Join(" ", OpenPB);
        }


    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void DradioButton_CheckedChanged(object sender, EventArgs e)
    {
        resbutton.Text = "расшифровать";
    }

    private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (textBox2.Text.Length == 0)
        {
            MessageBox.Show("Расшифруйте/зашифруйте!");
            return;
        }
        if (saveFile.ShowDialog() == DialogResult.OK)
        {
            using FileStream fileStream = new FileStream(saveFile.FileName, FileMode.Create);
            foreach (var item in CRes)
            {
                byte[] bytes = BitConverter.GetBytes(item);
                fileStream.Write(bytes, 0, bytes.Length);
            }

        }
    }

    private void resbutton_Click(object sender, EventArgs e)
    {
        if (CradioButton.Checked)
        {
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Откройте файл с исходным текстом");
                return;
            }
            CRes = new ushort[OpenPB.Length];
            for (int i = 0; i < CRes.Length; i++)
            {
                CRes[i] = OpenPB[i];
            }
            for (int i = 0; i < CRes.Length; i++)
            {
                CRes[i] = (ushort)RSA.QPowMod(CRes[i], E, R);
            }
            textBox2.Text = string.Join(" ", CRes);
        }
        if (DradioButton.Checked)
        {
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Откройте файл с исходным текстом");
                return;

            }
            ushort[] tempSh = new ushort[CRes.Length];
            for (int i = 0; i < tempSh.Length; i++)
            {
                tempSh[i] = (ushort)RSA.QPowMod(CRes[i], D, R);

            }
            DRes = new byte[tempSh.Length];
            for (var index = 0; index < tempSh.Length; index++)
            {
                var item = tempSh[index];
                var bytes = BitConverter.GetBytes(item);
                if (!BitConverter.IsLittleEndian)
                    Array.Reverse(bytes);
                DRes[index] = bytes[0];
            }
            textBox2.Text = string.Join(" ", tempSh);
        }

    }

    private void открытьЗашифрованныйТекстToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (openFile.ShowDialog() != DialogResult.Cancel)
        {
            OpenCB = File.ReadAllBytes(openFile.FileName);
            if (OpenCB.Length % 2 != 0)
            {
                OpenCB = OpenCB.Append((byte)0).ToArray();
            }
            CRes = new ushort[OpenCB.Length / 2];
            for (int i = 0; i < OpenCB.Length; i += 2)
            {
                byte[] bytes = [OpenCB[i], OpenCB[i + 1]];
                ushort sh = BitConverter.ToUInt16(bytes, 0);
                CRes[i / 2] = sh;
            }

            textBox1.Text = string.Join(" ", CRes);
        }
    }

    private void сохранитьРасшифрованныйТекстToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (textBox2.Text.Length == 0)
        {
            MessageBox.Show("Расшифруйте/зашифруйте!");
            return;
        }
        if (saveFile.ShowDialog() == DialogResult.OK)
        {
            File.WriteAllBytes(saveFile.FileName, DRes);

        }
    }
}