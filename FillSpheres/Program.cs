using System;

namespace FillSpheres
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("COR");
            int cor1=Console.Read();
            byte cor = Convert.ToByte(cor1);
            Console.WriteLine("raio");
            int raio=Console.Read();
            int n =0;
            Sphere sphe = new Sphere(cor,raio,n);
        }
    }

    class Color
    {
        private byte red = 0;
        private byte green = 0;
        private byte blue = 0;
        private byte alpha = 0;

        public Color(byte red, byte green, byte blue, byte alpha)
        {

            

        }

        public Color(byte red, byte green, byte blue)
        {
            alpha=255;
            

        }

        public int ColorRED
        {
            get
            {
                return red;
            }
            set
            {
                red=230;

            }
            
        }
        public int ColorGREEN
        {
           get
           {
            return green;
           }
           set
           {
            green=23;
           }
            
            
        }
        public int ColorBLUE
        {
           get
           {
            return blue;
           }
           set 
           {
            blue=23;
           } 
        }

        public int ColorALPHA
        {
            get
            {
                return alpha;
            }
            set
            {
                alpha=255;
            }  
        }

        public int GetGrey(byte red,byte green,byte blue)
        {

            return (red+green+blue)/3;
        }



    }
    
    class Sphere
    {
        byte cor;
        int raio;
        int n;

        public Sphere(byte cor,int raio,int n)
        {
            
        }
        public int Pop()
        {
            return raio=0;
        }
        public int Throw()
        {
            if (raio>0){

                return n;
            }else{
                return n =n+1;
            }
        }
        public int GetTimesThrow()
        {
            return n;
        }

    }
}
