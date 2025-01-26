using System.Data;

namespace Klinrek.Class {
    public static class Mapper {
        public static List<ClinicalRecomendation> MapReccomendations(DataSet data) {
            DataTable? recTable = data.Tables["КР"]; // Таблица кодов МКБ и КлинРеков
            List<ClinicalRecomendation> clinicals = new List<ClinicalRecomendation>(); // Десериализованный лист кодов МКБ и соответствующих клинреков
            
            if (recTable != null) {
                for (int i = 1; i < recTable.Rows.Count; i++) { 
                    List<Guidance>? guidancesList = new List<Guidance>(); // Список реков
                    if (int.TryParse(recTable.Rows[i].ItemArray[2]?.ToString(), out int guidanceCount)) { // Выясняем сколько реков
                        for (int j = 3; j <= guidanceCount*3; j += 3) { // Описание одной реки занимает три столбца, поэтому шаг - 3
                            guidancesList.Add(new Guidance(recTable.Rows[i].ItemArray[j]?.ToString() ?? string.Empty,
                            recTable.Rows[i].ItemArray[j+1]?.ToString() ?? string.Empty,
                            recTable.Rows[i].ItemArray[j+2]?.ToString() ?? string.Empty));
                        }
                    }
                    // Добавляем в болячку с реками в список
                    clinicals.Add(new ClinicalRecomendation(recTable.Rows[i].ItemArray[0]?.ToString() ?? string.Empty,
                    recTable.Rows[i].ItemArray[1]?.ToString() ?? string.Empty,
                    guidancesList));
                }
            }
            return clinicals;
        }
    }
}