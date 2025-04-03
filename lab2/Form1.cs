using System;
using System.Collections;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace ti2;

public partial class Form1 : Form
{
    readonly Cipher cipher = new();
    OpenFileDialog openFileDialog = new();
    SaveFileDialog saveFileDialog = new();
    public Form1()
    {
        InitializeComponent();
    }

    private void label3_Click(object sender, EventArgs e)
    {
        
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
        label1.Text = $@"Длина введенных состояний: {textBox1.Text.Count(x => x is '0' or '1')}";
    }
    
    string ArrToStr(BitArray array)
    {
        StringBuilder temp = new();
        if (array.Length <= 240)
        {
            foreach (bool bit in array)
            {
                temp.Append(bit ? 1 : 0);
            }       
        }
        else
        {
            temp.Append("Первые 15 байт: \n");
            for (int i = 0; i < 120; i++)
                temp.Append(array[i] ? 1 : 0);
            temp.Append($"{Environment.NewLine}Последние 15 байт: \n");
            for (int i = 120; i > 0; i--)
            {
                temp.Append(array[array.Length - i] ? 1 : 0);
            }
        }

        return temp.ToString();
    }


    private void button1_Click(object sender, EventArgs e)
    {
        textBox1.Text = string.Join("",textBox1.Text.Where(x=>x is'0' or '1'));
        if (textBox1.Text.Length != 28)
        {
            MessageBox.Show("Длина вашего регистра должна равняться 28 состояниям!", "Внимание");
            return;
        }

        if (textBox2.Text.Length == 0)
        {
            MessageBox.Show("Выберите файл с вашим исходным текстом для шифрования/дешифрования!", "Внимание");
            return;
        }
        cipher.makeRegister(textBox1.Text);
        cipher.makeKey(cipher.PText.Length);
        textBox4.Text = ArrToStr(cipher.Key);
        
        cipher.crCipher();
        textBox3.Text = ArrToStr(cipher.CipherB);
    }

    void button3_Click(object sender, EventArgs e)
    {
        if (openFileDialog.ShowDialog() != DialogResult.Cancel)
        {
            StringBuilder str = new();
            var bytes = File.ReadAllBytes(openFileDialog.FileName);
            for (int i = 0; i < bytes.Length; i++)
            {
                BitArray help = new BitArray(new[] { bytes[i] });
                foreach (bool bit in help)
                {
                    str.Append(bit ? 1 : 0);
                }
                
            }
            cipher.PText = new BitArray(str.Length);
            for (int i = 0; i < cipher.PText.Length; i++)
            {
                cipher.PText[i] = str[i] == '1';
            }
            textBox2.Text = ArrToStr(cipher.PText);

        }
    }

    private void button4_Click(object sender, EventArgs e)
    {
        if (saveFileDialog.ShowDialog() != DialogResult.Cancel)
        {
            using FileStream fileStream = new FileStream(saveFileDialog.FileName, FileMode.Create);
            byte[] result = new byte[cipher.CipherB.Count / 8];
            cipher.CipherB.CopyTo(result, 0);
            fileStream.Write(result, 0, result.Length);
        }
    }

    private void button2_Click(object sender, EventArgs e)
    {
        textBox2.Clear();
        textBox3.Clear();
        textBox4.Clear();
    }
}