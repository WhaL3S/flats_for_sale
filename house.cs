class House
    {
        const int Cmax = 50;
        private Flat[] Flats;
        private int n;

        public House()
        {
            n = 0;
            Flats = new Flat[Cmax];
        }

        public Flat Get(int i) { return Flats[i]; }
        public int Get() { return n; }
        public void Add(Flat flat) { Flats[n++] = flat; }
    }
