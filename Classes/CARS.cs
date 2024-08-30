namespace CARS.Classes
{
    public class Cars
    {
        private  string model;
        private int year;
        private decimal price;
        private decimal speed;
        public Cars(string model,int year,decimal price,decimal speed)
        {
            this.model=model;
            this.year=year;
            this.price=price;
            this.speed=speed;
        }
        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                model=value;
            }
        }
        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                year=value;
            }
        }
        public decimal Price
        {
            get
            {
                return price;
            }
            set
            {
                price=value;
            }

        }
        public decimal Speed
        {
            get
            {
                return speed;
            }
            set
            {
                speed=value;
            }
        }
        public string GetCarInfo()
        {
            return $"Model:{model}, Yil:{year}, Narx:{price} USD, Tezlik:{speed} km/soat ";
        }
        public decimal CalculateDepreciation(int years)
        {
            decimal depreciationRate=0.10m;
            decimal depreciationPrice=price;
            for(int i=0;i<years;i++)
            {
                depreciationPrice-=depreciationPrice*depreciationRate;
            }
            return depreciationPrice;
        }
    }
}