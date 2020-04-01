namespace GitExercise
{
    class myClass
    {
        public string name { get; set; }

        public string address { get; set; }
        public int postnr { get; set; }

        public myClass(string name, string address)
    {
        this.name = name;
        this.address = address;
    }
    }
}