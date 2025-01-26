using System.Data;

namespace Klinrek.Class {
    public static class Mapper {
        public static List<ClinicalRecomendation> MapReccomendations(DataSet data) {
            DataTable? recomendationsTable = data.Tables["КР"]; // Таблица с клинреками
            List<ClinicalRecomendation> clinicals = new List<ClinicalRecomendation>(); // Десериализованный лист реков
            
            if (recomendationsTable != null) {
                for (int i = 1; i <= recomendationsTable.Rows.Count; i++) {
                    List<Guidance>? guidancesList = new List<Guidance>();
                    if (recomendationsTable.Rows[i].ItemArray[2] is int guidanceCount) {
                        for (int j = 3; j <= guidanceCount;j += 3) {
                            guidanceDic.Add(new )
                        }
                    }
                    clinicals.Add(new ClinicalRecomendation(recomendationsTable.Rows[i].ItemArray[0]?.ToString() ?? string.Empty,
                    recomendationsTable.Rows[i].ItemArray[1]?.ToString() ?? string.Empty,
                    null));
                }
            }

            return clinicals;
        }
    }
}