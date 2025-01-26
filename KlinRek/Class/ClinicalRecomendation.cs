namespace Klinrek.Class {
    public class ClinicalRecomendation { 
        public string ICD {get; set;} = string.Empty;
        public string ICDName {get; set;} = string.Empty;
        public Dictionary<Dictionary<string, string>, string>? Guidance {get; set;}

    }
}