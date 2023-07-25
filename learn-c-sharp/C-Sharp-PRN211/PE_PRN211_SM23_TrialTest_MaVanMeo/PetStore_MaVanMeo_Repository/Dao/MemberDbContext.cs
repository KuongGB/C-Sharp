using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetStore_MaVanMeo_Repository.Models;

namespace PetStore_MaVanMeo_Repository.Dao;

public class MemberDbContext:PetShop2023DBContext
{
    private static MemberDbContext instance = null;
    private static readonly object instanceLock = new object(); 
    private MemberDbContext()
    {

    }
    public static MemberDbContext Instance
    {
        get
        {
            lock (instanceLock)
            {
                if (instance == null)
                {
                    instance = new MemberDbContext();
                }
                return instance;
            }
        }
    }
    //return 1 member by Id
    public PetShopMember GetMemberById(string id)
    {
        return this.PetShopMembers.FirstOrDefault(m => m.MemberId.Equals(id));

    }
    public IEnumerable<PetShopMember> GetAllMembers()
    {
        return this.PetShopMembers.ToList();
    }
}
