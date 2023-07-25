using PetStore_MaVanMeo_Repository.Dao;
using PetStore_MaVanMeo_Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore_MaVanMeo_Repository.Repository;

public class PetRepository : IPetRepository
{
    public void AddPet(Pet pet)
    {
        PetDbContext.Instance.Add(pet);
    }

    public void DeletePet(Pet pet)
    {
        DeletePet(pet.PetId);
    }

    public void DeletePet(int id)
    {
        PetDbContext.Instance.DeletePet(id);
    }

    public IEnumerable<Pet> GetAllPets()
        => PetDbContext.Instance.GetAllPets();

    public Pet GetPetById(int id)
    => PetDbContext.Instance.GetPetById(id);

    public void UpdatePet(Pet pet)
        => PetDbContext.Instance.UpdatePet(pet);
}
