namespace Klinrek.Class {
    public static class MarkDowner {
        public static string TableContent(List<ClinicalRecomendation> clinICDnRekList) {
            string tableContent = "|Код по МКБ|Диагноз|Клинические рекомендации|\n";
            tableContent += "|--|--|--|\n";
            foreach(ClinicalRecomendation ICDnClinRec in clinICDnRekList) {
                tableContent += "|"+ICDnClinRec.ICD+"|"+ICDnClinRec.ICDName+"|";
                foreach (Guidance guidance in ICDnClinRec.Guidance) {
                    tableContent += "[**" + guidance.Code + "** " + guidance.Name + "] (<../PDF/"+ guidance.FileName +">) <br>";
                }
                tableContent += "|\n";
            }
            return tableContent;
        }
    }
}