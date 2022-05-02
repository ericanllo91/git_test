using mtg_lib.Library.Models;


class Start {
    static void Main(string[] args){
        magicContext context = new magicContext();

        var myList = context.Colors
            .OrderBy(c => c.Name)
            .ToList();

        foreach(var item in myList){
            Console.WriteLine(item.CardColors);
        }
    }
}