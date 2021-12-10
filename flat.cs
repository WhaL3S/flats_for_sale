class Flat
    {
        private int number;
        private int totalArea;
        private int numberOfRooms;
        private int salePrice;
        private int telephoneNumber;

        public Flat(int number, int totalArea, int numberOfRooms, int salePrice, int telephoneNumber)
        {
            this.number = number;
            this.totalArea = totalArea;
            this.numberOfRooms = numberOfRooms;
            this.salePrice = salePrice;
            this.telephoneNumber = telephoneNumber;
        }

        public string Table()
        {
            string line;
            line = string.Format("{0, 4} {1, 10} {2, 15} {3, 18} {4, 16}",
                 number, totalArea, numberOfRooms, salePrice, telephoneNumber);
            return line;
        }

        public int GetNumber() { return number; }
        public int GetTotalArea() { return totalArea; }
        public int GetNumberofRooms() { return numberOfRooms; }
        public int GetSalePrice() { return salePrice; }
        public int GetTelephoneNumber() { return telephoneNumber; }

    }
