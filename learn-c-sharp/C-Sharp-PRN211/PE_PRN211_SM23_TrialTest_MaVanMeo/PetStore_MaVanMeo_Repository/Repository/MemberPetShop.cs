using PetStore_MaVanMeo_Repository.Models;
using PetStore_MaVanMeo_Repository.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore_MaVanMeo_Repository.Repository;

public class MemberPetShop : IMemberRepository
{
    public PetShopMember GetMember(string id)
        => MemberDbContext.Instance.GetMemberById(id);

    public IEnumerable<PetShopMember> GetMembers()
    => MemberDbContext.Instance.GetAllMembers();
}
