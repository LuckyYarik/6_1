using laba_6_1_1;

namespace WinFormsApp1
{
    class Ugaday
    {
        private int tryes;
        private double fn;
        
        public Ugaday(int tryes, double a, double b)
        {
            this.tryes = tryes;
            this.fn = Fn(a, b);
        }
        static double Fn(double a, double b)
        {
            const double P = Math.PI;
            double bInRadians = b * (P / 180);
            return Math.Round(Math.Sqrt(Math.Cos(bInRadians)) + Math.Sin((3 * P / 4) + (a / 3)),2);
        }

        public bool CheckEnd(double ans)
        {
            if (this.tryes > 0 && ans != this.fn)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public string Ugadaika(double curAnswer)
        {
            if (curAnswer == this.fn)
            {
                return $"�� �������, ���������� ����� ��� {this.fn}";
            }
            else if (--this.tryes > 0)
            {
                return $"�� �� �������, � ��� ��� {this.tryes} �������";
            }
            else
            {
                return $"�� �� ������� � � ��� ��������� �������, ���������� ����� ��� {this.fn}";
            }
        }
    }
}