namespace DestinoComum2.Models
{
    public class RespostaModel<T>
    {
        public T? Dados { get; set; }
        public string Mensagem { get; set; } = string.Empty;
        public bool Status {  get; set; }=true;
    }
}
