namespace ByteBank_SystemAgency.Models.Entities
{
    public class Button
    {
        public string Text { get; set; }
        public BottonColors Color { get; set; }
    }

    static class Colors
    {
        public static readonly string Blue = "Azul";
        public static readonly string Red = "Vermelho";
        public static readonly string Green = "Verde";
    }

    public enum BottonColors
    {
        Blue,
        Red,
        Green
    }
}
