using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw_esww_cryp
{
    public partial class Form1 : Form
    {
        char[] ENG_alph = "abcdefghijklmnopqrstuvwxyz123456789".ToCharArray();
        char[] RUS_alph = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя123456789".ToCharArray();
        BigInteger step_count;
        bool exept = false; // перемнная для отлова ошибок 
        bool isTitle = false;

        public Form1()
        {
            InitializeComponent();
        }
        private void Encrypt_btn_Click(object sender, EventArgs e)
        {
            exept = false; isTitle = false;
            if (!CheckStepTB()) return; // Если есть какие-либо нарушения в веденном шаге, то выходим
            string result = ""; // Поле для результата шифрации 
            var input_text = Input_TB.Text.ToCharArray(); // Поле для изначального текста
            int ch_pos = 0;
            char[] alph;

            if (RUS_ALPHABET.Checked) alph = RUS_alph;  //если используеться русский алфавит
            else alph = ENG_alph;                       //если используеться английски алфавит алфавит
            
            for (int i = 0; i < input_text.Length; i++)
            {
                if(char.IsLetter(input_text[i])) // если текущий символ - буква
                    isTitle = input_text[i] == char.ToUpper(input_text[i]) ? true : false; // проверяем регистр текущей буквы
                ch_pos = GetChPosIndex(char.ToLower(input_text[i]), alph); //Записываем позицию текущей буквы в алфавите в нижнем регистре
                if (ch_pos != -1)
                {
                    if(isTitle) // если верхний регистр
                        result += char.ToUpper( alph[GetNewChPos(ch_pos, step_count, alph.Length)]);
                    else
                        result += alph[GetNewChPos(ch_pos, step_count, alph.Length)];
                }
                else exept = true;
            }
            if (exept) MessageBox.Show("Некоторые введенные символы не содержаться в выбранном алфавите! Они не были пропущены в ходе Шифровки");
            Output_tb.Text = result;
        }
        private void Decrypt_btn_Click(object sender, EventArgs e)
        {
            exept = false; isTitle = false;
            if (!CheckStepTB()) return; // Если есть какие-либо нарушения в веденном шаге, то выходим
            string result = ""; // Поле для результата расшифровки
            char[] input_text = Input_TB.Text.ToCharArray(), alph;
            int ch_pos = 0;

            if (RUS_ALPHABET.Checked) alph = RUS_alph; 
            else alph = ENG_alph;

            for (int i = 0; i < input_text.Length; i++)
            {
                if (char.IsLetter(input_text[i])) // если текущий символ - буква
                    isTitle = input_text[i] == char.ToUpper(input_text[i]) ? true : false; // проверяем регистр текущей буквы
                ch_pos = GetChPosIndex(char.ToLower( input_text[i]), alph);
                if (ch_pos != -1)
                {
                    if (isTitle)
                        result += char.ToUpper(alph[GetNewChPosDecrypt(ch_pos, step_count, alph.Length)]);
                    else
                        result += alph[GetNewChPosDecrypt(ch_pos, step_count, alph.Length)];
                }
                else exept = true;
            }

            if (exept) MessageBox.Show("Некоторые введенные символы не содержаться в выбранном алфавите! Они не были пропущены в ходе Расшифровки");
            Output_tb.Text = result;
        }
        public static int GetChPosIndex(char ch, char[] alph)
        {
            for (int i = 0; i < alph.Length; i++)
            {
                if (ch == alph[i]) return i;
            }
            return -1;
        }
        public static int GetNewChPos(int old_ind, BigInteger step_count, int alph_length)
        {
            return Math.Abs((int)((old_ind + step_count ) % alph_length));
        }
        public static int GetNewChPosDecrypt(int old_ind, BigInteger step_count, int alph_length)
        {
            return Math.Abs((int)((alph_length+old_ind - step_count) % alph_length));
        }
        public bool CheckStepTB()
        {
            if (step_count_tb.Text.Length == 0) { MessageBox.Show("Заполните поле шага!"); return false; }
            try
            {
                step_count = BigInteger.Parse(step_count_tb.Text); return true;
            }
            catch
            {
                MessageBox.Show("В поле шаг можно вводить только число!"); return false;
            }
        }
        private void Revers_btn_Click(object sender, EventArgs e)
        {
            Input_TB.Text = Output_tb.Text;
            Output_tb.Text="";
        }
    }
}
