using System;

namespace _05._Supplies_for_School
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input

            int penPakets = int.Parse(Console.ReadLine());
            int markerPakets = int.Parse(Console.ReadLine());
            int litresBoardCleaner = int.Parse(Console.ReadLine());
            int percentDiscount = int.Parse(Console.ReadLine());

            // calculate

            double pricePenPakets = penPakets * 5.80;
            double priceMarkerPakets = markerPakets * 7.20;
            double priceLitresBoardCleaner = litresBoardCleaner * 1.20;
            double pricePecentDiscount = pricePenPakets + priceMarkerPakets + priceLitresBoardCleaner;
            double priceWithDiscount = pricePecentDiscount - (pricePecentDiscount * percentDiscount / 100);

            // output

            Console.WriteLine(priceWithDiscount);
            
        }
    }
}
