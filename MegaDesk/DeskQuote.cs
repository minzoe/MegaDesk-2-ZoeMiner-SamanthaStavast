using System;

namespace MegaDesk
{
    class DeskQuote
    {

        // constants
        const decimal BASE_DESK_PRICE = 200.00M;
        const decimal SURFACE_AREA_COST = 1.00M;
        const decimal DRAWER_COST = 50.00M;
        const decimal OAK_COST = 200.00M;
        const decimal LAMINATE_COST = 100.00M;
        const decimal PINE_COST = 50.00M;
        const decimal ROSEWOOD_COST = 300.00M;
        const decimal VENEER_COST = 125.00M;
        const decimal Day3_Less = 60M;
        const decimal Day3_Mid = 70M;
        const decimal Day3_Great = 80M;
        const decimal Day5_Less = 40M;
        const decimal Day5_Mid = 50M;
        const decimal Day5_Great = 60M;
        const decimal Day7_Less = 30M;
        const decimal Day7_Mid = 35M;
        const decimal Day7_Great = 40M;

        // enums
        public enum Delivery
        {
            Rush3Days,
            Rush5Days,
            Rush7Days,
            Normal14Days
        }

        public Desk Desk { get; }
        public Delivery Shipping { get; }
        public string Customer { get; }
        public DateTime Date { get; }
        

        public DeskQuote(Desk desk, Delivery time, string name, DateTime date)
        {
            Desk = desk;
            Shipping = time;
            Customer = name;
            Date = date;
        }

        public decimal GetQuote(Desk desk, DeskQuote deskQuote)
        {
            decimal totalQuote = BASE_DESK_PRICE;
            decimal surfaceArea = desk.Width * desk.Depth;

            if (surfaceArea > 1000)
            {
                totalQuote += (surfaceArea - 1000);
            }

            if (desk.Drawers != 0)
            {
                totalQuote += (desk.Drawers * 50);
            }

            switch (desk.Material)
            {
                case Desk.SurfaceMaterial.Oak:
                    totalQuote += OAK_COST;
                    break;

                case Desk.SurfaceMaterial.Laminate:
                    totalQuote += LAMINATE_COST;
                    break;

                case Desk.SurfaceMaterial.Pine:
                    totalQuote += PINE_COST;
                    break;

                case Desk.SurfaceMaterial.Rosewood:
                    totalQuote += ROSEWOOD_COST;
                    break;

                case Desk.SurfaceMaterial.Veneer:
                    totalQuote += VENEER_COST;
                    break;

                default:
                    break;
            }

            if (deskQuote.Shipping == Delivery.Normal14Days)
            {
                totalQuote += 0;
            }
            else if (deskQuote.Shipping == Delivery.Rush3Days)
            {
                if (surfaceArea < 1000)
                {
                    totalQuote += Day3_Less;
                }
                else if (surfaceArea > 2000)
                {
                    totalQuote += Day3_Great;
                }
                else
                {
                    totalQuote += Day3_Mid;
                }
            }
            else if (deskQuote.Shipping == Delivery.Rush5Days)
            {
                if (surfaceArea < 1000)
                {
                    totalQuote += Day5_Less;
                }
                else if (surfaceArea > 2000)
                {
                    totalQuote += Day5_Great;
                }
                else
                {
                    totalQuote += Day5_Mid;
                }
            }
            else if (deskQuote.Shipping == Delivery.Rush7Days)
            {
                if (surfaceArea < 1000)
                {
                    totalQuote += Day7_Less;
                }
                else if (surfaceArea > 2000)
                {
                    totalQuote += Day7_Great;
                }
                else
                {
                    totalQuote += Day7_Mid;
                }
            }        

            return totalQuote;
        }
    }
}
