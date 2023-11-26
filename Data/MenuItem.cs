namespace BlazorCrateComponent.Data
{
    public class MenuItem
    {
        public string Text { get; set; }
        public List<MenuItem> Items { get; set; }

        // Jika Anda ingin menambahkan properti lain, Anda bisa menambahkannya di sini.

        //public MenuItem(string text)
        //{
        //    Text = text;
        //    Items = new List<MenuItem>();
        //}
    }
}
