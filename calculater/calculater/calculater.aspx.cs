using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace calculater
{
    public partial class calculatercalculater : System.Web.UI.Page
    {
        static int num;
        static char calc;
        protected void Button1_Click(object sender, EventArgs e)
        {
            calcation.InnerText += 1;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            calcation.InnerText += 2;

        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            calcation.InnerText += 3;

        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            calcation.InnerText += 4;

        }
        protected void Button5_Click(object sender, EventArgs e)
        {
            calcation.InnerText += 5;

        }
        protected void Button6_Click(object sender, EventArgs e)
        {
            calcation.InnerText += 6;

        }
        protected void Button7_Click(object sender, EventArgs e)
        {
            calcation.InnerText += 7;

        }
        protected void Button8_Click(object sender, EventArgs e)
        {
            calcation.InnerText += 8;

        }
        protected void Button9_Click(object sender, EventArgs e)
        {
            calcation.InnerText += 9;

        }
        protected void Button0_Click(object sender, EventArgs e)
        {
            calcation.InnerText += 0;

        }
        protected void ButtonAdd_Click(object sender, EventArgs e)
        {
            num = Convert.ToInt32(calcation.InnerHtml);
            calc = '+';
            calcation.InnerText += "+";

        }
        protected void ButtonSub_Click(object sender, EventArgs e)
        {
            num = Convert.ToInt32(calcation.InnerHtml);

            calc = '-';
            calcation.InnerText += "-";

        }
        protected void ButtonMult_Click(object sender, EventArgs e)
        {
            num = Convert.ToInt32(calcation.InnerHtml);

            calc = '*';

            calcation.InnerText += "*";
        }
        protected void ButtonDiv_Click(object sender, EventArgs e)
        {
            num = Convert.ToInt32(calcation.InnerHtml);

            calc = '/';

            calcation.InnerText += "/";
        }
        protected void ButtoMood_Click(object sender, EventArgs e)
        {
            num = Convert.ToInt32(calcation.InnerText);
            calc = '%';
            calcation.InnerText += '%';

        }

        protected void ButtonEqual_Click(object sender, EventArgs e)
        {
            string temp = calcation.InnerText;
            string[] rest = new string[] { "", "" };
            int result;
            switch (calc)
            {
                case '+':
                    rest = temp.Split('+');
                    temp = rest[1];
                    result = Convert.ToInt32(temp);
                    resul.InnerText = Convert.ToString(num + result);
                    break;
                case '-':
                    rest = temp.Split('-');
                    temp = rest[1];
                    result = Convert.ToInt32(temp);
                    resul.InnerText = Convert.ToString(num - result);
                    break;
                case '/':
                    rest = temp.Split('/');
                    temp = rest[1];
                    result = Convert.ToInt32(temp);
                    resul.InnerText = Convert.ToString(num / result); 
                    break;
                case '*':
                    rest = temp.Split('*');
                    temp = rest[1];
                    result = Convert.ToInt32(temp);
                    resul.InnerText = Convert.ToString(num * result); 
                    break;
                case '%':
                    rest = temp.Split('%');
                    temp= rest[1];
                    result = Convert.ToInt32(temp);
                    resul.InnerText=Convert.ToString(num % result);
                    break;
            }


        }

       
    }



}