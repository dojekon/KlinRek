// See https://aka.ms/new-console-template for more information
using Klinrek.Class;
System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
//ProceedFile proceedFile = new ProceedFile("/home/sam-sepi0l/Документы/! КЛИНИЧЕСКИЕ РЕКОМЕНДАЦИИ/kr.xlsx");

using (StreamWriter outputFile = new StreamWriter(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "WriteLines.txt"))) {
    outputFile.WriteLine(MarkDowner.TableContent(Mapper.MapReccomendations(FileReader.ReadFile("/home/sam-sepi0l/Документы/! КЛИНИЧЕСКИЕ РЕКОМЕНДАЦИИ/kr.xlsx"))));
}
Console.WriteLine();