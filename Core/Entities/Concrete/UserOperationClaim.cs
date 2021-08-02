namespace Core.Entities.Concrete
{
    public class UserOperationClaim : IEntity
    {
        public int Id { get; set; }
        public int UsersId { get; set; }
        public int OperationClaimsId { get; set; }

    }

}
