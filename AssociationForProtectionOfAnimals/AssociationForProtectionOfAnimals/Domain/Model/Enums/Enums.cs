﻿
namespace LangLang.Domain.Model.Enums
{
    public enum Gender
    {
        Male,
        Female
    }

    public enum AccountType
    {
        RegisteredUser,
        Volunteer,
        Admin
    }

    public enum AnimalStatus
    {
        ForAdoption,
        Adopted,
        TemporarilyAdopted,
        UnderTreatment
    }


    public enum TypeOfRequest
    {
        UpdateAccountRequest,
        RegistrationRequest,
        AdoptionRequest,
        TemporaryAdoptionRequest,
        AddAnimalRequest,
        UpdateAnimalRequest
    }
}