using PetStore_MaVanMeo_Repository.Models;
namespace PetStore_MaVanMeo_Repository.Repository;

public interface IMemberRepository
{
    IEnumerable<PetShopMember> GetMembers();
    PetShopMember GetMember(string id);
}
