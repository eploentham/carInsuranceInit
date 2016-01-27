using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carInsuranceInit.object1
{
    class Config1
    {
        public String formatNumber = "{0:##,#.00}";
        public String formatInt = "{0:##,#}";
        public ComboBox setCboYearT(ComboBox c)
        {
            c.Items.Clear();
            c.Items.Add(System.DateTime.Now.Year + 543);
            c.Items.Add(System.DateTime.Now.Year + 543 - 1);
            c.Items.Add(System.DateTime.Now.Year + 543 - 2);
            c.SelectedIndex = c.FindStringExact(String.Concat(System.DateTime.Now.Year + 543));
            return c;
        }
        public ComboBox setCboYearE(ComboBox c)
        {
            c.Items.Clear();
            c.Items.Add(System.DateTime.Now.Year);
            c.Items.Add(System.DateTime.Now.Year - 1);
            c.Items.Add(System.DateTime.Now.Year - 2);
            c.SelectedIndex = c.FindStringExact(String.Concat(System.DateTime.Now.Year));
            return c;
        }
        public ComboBox setCboMonth(ComboBox c)
        {
            ComboBoxItem item = new ComboBoxItem();
            item.Value = "01";
            item.Text = "มกราคม";
            c.Items.Clear();
            c.Items.Add(item);
            item = new ComboBoxItem();
            item.Value = "02";
            item.Text = "กุมภาพันธ์";
            c.Items.Add(item);
            item = new ComboBoxItem();
            item.Value = "03";
            item.Text = "มีนาคม";
            c.Items.Add(item);
            item = new ComboBoxItem();
            item.Value = "04";
            item.Text = "เมษายน";
            c.Items.Add(item);
            item = new ComboBoxItem();
            item.Value = "05";
            item.Text = "พฤษาคม";
            c.Items.Add(item);
            item = new ComboBoxItem();
            item.Value = "06";
            item.Text = "มิถุนายน";
            c.Items.Add(item);
            item = new ComboBoxItem();
            item.Value = "07";
            item.Text = "กรกฎาคม";
            c.Items.Add(item);
            item = new ComboBoxItem();
            item.Value = "08";
            item.Text = "สิงหาคม";
            c.Items.Add(item);
            item = new ComboBoxItem();
            item.Value = "09";
            item.Text = "กันยายน";
            c.Items.Add(item);
            item = new ComboBoxItem();
            item.Value = "10";
            item.Text = "ตุลาคม";
            c.Items.Add(item);
            item = new ComboBoxItem();
            item.Value = "11";
            item.Text = "พฤศจิกายน";
            c.Items.Add(item);
            item = new ComboBoxItem();
            item.Value = "12";
            item.Text = "ธันวาคม";
            c.Items.Add(item);
            //c.Items.Add("มกราคม");
            //c.Items.Add("กุมภาพันธ์");
            //c.Items.Add("มีนาคม");
            //c.Items.Add("เมษายน");
            //c.Items.Add("พฤษาคม");
            //c.Items.Add("มิถุนายน");
            //c.Items.Add("กรกฎาคม");
            //c.Items.Add("สิงหาคม");
            //c.Items.Add("กันยายน");
            //c.Items.Add("ตุลาคม");
            //c.Items.Add("พฤศจิกายน");
            //c.Items.Add("ธันวาคม");
            c.SelectedIndex = c.FindStringExact(getMonth(System.DateTime.Now.Month.ToString("00")));
            return c;
        }
        public ComboBox setCboDoctor(ComboBox c)
        {
            c.Items.Clear();
            c.Items.Add("แพทย์หญิง กรกนก  ดีสุคนธ์");
            c.Items.Add("แพทย์หญิง อรวรรณ  แซ่เฉิน");
            c.Items.Add("นายแพทย์ ชุตินันท์ พรหมมินทร์");

            //c.Items.Add("พ.ญ. อรวรรณ  แซ่เฉิน");
            return c;
        }
        public String getMonth(String monthId)
        {
            if (monthId == "01")
            {
                return "มกราคม";
            }
            else if (monthId == "02")
            {
                return "กุมภาพันธ์";
            }
            else if (monthId == "03")
            {
                return "มีนาคม";
            }
            else if (monthId == "04")
            {
                return "เมษายน";
            }
            else if (monthId == "05")
            {
                return "พฤษาคม";
            }
            else if (monthId == "06")
            {
                return "มิถุนายน";
            }
            else if (monthId == "07")
            {
                return "กรกฎาคม";
            }
            else if (monthId == "08")
            {
                return "สิงหาคม";
            }
            else if (monthId == "09")
            {
                return "กันยายน";
            }
            else if (monthId == "10")
            {
                return "ตุลาคม";
            }
            else if (monthId == "11")
            {
                return "พฤศจิกายน";
            }
            else if (monthId == "12")
            {
                return "ธันวาคม";
            }
            else
            {
                return "";
            }
        }
        public String getMonthId(String monthId)
        {
            if (monthId == "มกราคม")
            {
                return "01";
            }
            else if (monthId == "กุมภาพันธ์")
            {
                return "02";
            }
            else if (monthId == "มีนาคม")
            {
                return "03";
            }
            else if (monthId == "เมษายน")
            {
                return "04";
            }
            else if (monthId == "พฤษาคม")
            {
                return "05";
            }
            else if (monthId == "มิถุนายน")
            {
                return "06";
            }
            else if (monthId == "กรกฎาคม")
            {
                return "07";
            }
            else if (monthId == "สิงหาคม")
            {
                return "08";
            }
            else if (monthId == "กันยายน")
            {
                return "09";
            }
            else if (monthId == "ตุลาคม")
            {
                return "10";
            }
            else if (monthId == "พฤศจิกายน")
            {
                return "11";
            }
            else if (monthId == "ธันวาคม")
            {
                return "12";
            }
            else
            {
                return "";
            }
        }
        public String stringNull(String txt)
        {
            if (txt == null)
            {
                return "";
            }
            else
            {
                return txt;
            }
        }
        public String datetoDB(object dt)
        {
            DateTime dt1 = new DateTime();
            try
            {
                if (dt == null)
                {
                    return "";
                }
                else if (dt == "")
                {
                    return "";
                }
                else
                {
                    dt1 = DateTime.Parse(dt.ToString());
                    if (dt1.Year <= 2500)
                    {
                        return String.Concat((dt1.Year + 543), "-") + dt1.Month.ToString("00") + "-" + dt1.Day.ToString("00");
                    }
                    else
                    {
                        return dt1.Year.ToString() + "-" + dt1.Month.ToString("00") + "-" + dt1.Day.ToString("00");
                    }

                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public String datetoDB1(object dt)
        {
            DateTime dt1 = new DateTime();
            try
            {
                if (dt == null)
                {
                    return "";
                }
                else if (dt == "")
                {
                    return "";
                }
                else
                {
                    dt1 = DateTime.Parse(dt.ToString());
                    if (dt1.Year <= 1500)
                    {
                        return String.Concat((dt1.Year + 543), "-") + dt1.Month.ToString("00") + "-" + dt1.Day.ToString("00");
                    }
                    else
                    {
                        return dt1.Year.ToString() + "-" + dt1.Month.ToString("00") + "-" + dt1.Day.ToString("00");
                    }

                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public String dateDBtoShow(String dt)
        {
            if (dt != "")
            {
                return dt.Substring(8, 2) + "-" + dt.Substring(5, 2) + "-" + String.Concat(Int16.Parse(dt.Substring(0, 4)) + 543);
            }
            else
            {
                return dt;
            }
        }
        public String dateDBtoShow1(String dt)
        {
            if (dt != "")
            {
                return dt.Substring(8, 2) + "-" + dt.Substring(5, 2) + "-" + dt.Substring(0, 4);
            }
            else
            {
                return dt;
            }
        }
        public String ObjectNull(object o)
        {
            if (o == null)
            {
                return "";
            }
            else
            {
                return o.ToString();
            }
        }
        public String NumberNull(object o)
        {
            float a = new float();
            try
            {
                if (ObjectNull(o) != "")
                {
                    a = float.Parse(o.ToString());
                }
                else
                {
                    a = 0;
                }
            }
            catch (Exception ex)
            {
                a = 0;
            }
            return String.Format(formatNumber, a);            
        }
        //public String NumberNull1(object o)
        //{
        //    //float a = new float();
        //    try
        //    {
        //        if (ObjectNull(o) != "")
        //        {
        //            //a = float.Parse(o);
        //        }
        //        else
        //        {
        //            //a = 0;
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        a = 0;
        //    }
        //    return String.Format(formatNumber, a);
        //}
        public String shortPaidName(String name)
        {
            if (name == "ประกันสังคม (บ.1)")
            {
                return "ปกส(บ.1)";
            }
            else if (name == "ประกันสังคม (บ.2)")
            {
                return "ปกส(บ.2)";
            }
            else if (name == "ประกันสังคม (บ.5)")
            {
                return "ปกส(บ.5)";
            }
            else if (name == "ประกันสังคมอิสระ (บ.1)")
            {
                return "ปกต(บ.1)";
            }
            else if (name == "ประกันสังคมอิสระ (บ.5)")
            {
                return "ปกต(บ.5)";
            }
            else if (name == "ตรวจสุขภาพ (เงินสด)")
            {
                return "ตส(เงินสด)";
            }
            else if (name == "ตรวจสุขภาพ (บริษัท)")
            {
                return "ตส(บริษัท)";
            }
            else if (name == "ตรวจสุขภาพ (PACKAGE)")
            {
                return "ตส(PACKAGE)";
            }
            else if (name == "ลูกหนี้ประกันสังคม รพ.เมืองสมุทรปากน้ำ")
            {
                return "ลูกหนี้(ปากน้ำ)";
            }
            else if (name == "ลูกหนี้บางนา 1")
            {
                return "ลูกหนี้(บ.1)";
            }
            else if (name == "บริษัทประกัน")
            {
                return "บ.ประกัน";
            }
            else if (name == "ลูกหนี้ประกันสังคม รพ.เมืองสมุทรปู่เจ้า")
            {
                return "ลูกหนี้(ปู่เจ้า)";
            }
            else
            {
                return name;
            }
        }
        public String getEndDateofMonth(int yearId, int monthId)
        {
            DateTime endOfMonth = new DateTime(yearId, monthId, DateTime.DaysInMonth(yearId, monthId));
            return endOfMonth.ToString("yyyy-MM-dd");
        }
        public String getCurrDate()
        {
            return (System.DateTime.Now.Year+543) + "-" + System.DateTime.Now.Month.ToString("00") + "-" + System.DateTime.Now.Day.ToString("00");
        }
    }
}
