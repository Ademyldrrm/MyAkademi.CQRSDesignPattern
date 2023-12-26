namespace MyAkademi.CQRSDesignPattern.CQRSPattern.Queries
{
    public class GetCategoyByIdQuery
    {
        public GetCategoyByIdQuery(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
