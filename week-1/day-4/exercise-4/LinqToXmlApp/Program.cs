using System.Xml.Linq;

namespace LinqToXmlApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Assume there is an XML document with the following structure:
            // <Books>
            //     <Book>
            //         <Title>Book Title 1</Title>
            //         <Author>Author 1</Author>
            //         <Genre>Genre 1</Genre>
            //     </Book>
            //     ...
            // </Books>
            // Write above book structure as a c# string
            string xmlString = @"<Books>
                                    <Book>
                                        <Title>A passage to India </Title>
                                        <Author>E M Foster</Author>
                                        <Genre>Travel </Genre>
                                    </Book>
                                    <Book>
                                        <Title>Harry potter</Title>
                                        <Author>J K R </Author>
                                        <Genre> fantacy</Genre>
                                    </Book>
                                    <Book>
                                        <Title>Making India awesome </Title>
                                        <Author>Chetan Bhagath </Author>
                                        <Genre>Political</Genre>
                                    </Book>
                                </Books>";

            // Create an XDocument object from the XML

            XDocument doc = XDocument.Parse(xmlString);
            Console.WriteLine(doc);


            // Write the title of all books to the console
            foreach (var book in doc.Descendants("Book"))
            {
                Console.WriteLine(book.Element("Title").Value);
            }

            // Write the title of all books with genre "Genre 1" to the console
            foreach (var book in doc.Descendants("Book").Where(b => b.Element("Genre").Value == "Political"))
            {
                Console.WriteLine(book.Element("Title").Value);
            }
          

        }
    }
}