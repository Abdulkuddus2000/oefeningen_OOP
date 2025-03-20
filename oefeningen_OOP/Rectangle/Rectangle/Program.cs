namespace Figures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle();
            r1.Height = -1;
            r1.Width = 0;

            Rectangle r2 = new Rectangle();
            r2.Width = 2.2;
            r2.Height = 1.5;
            
            Rectangle r3 = new Rectangle();
            r3.Width = 3;
            r3.Height = 1;

            Triangle t1 = new Triangle();
            t1.Base = 3;
            t1.Height = 1;
            
            Triangle t2 = new Triangle();
            t2.Base = 2;
            t2.Height = 2;


            r1.ShowInfo();
            r2.ShowInfo();
            r3.ShowInfo();
            t1.ShowInfo();
            t2.ShowInfo();
        }
    }
}
