﻿namespace NorthWind.UserServices;

internal class UserServiceFake : IUserService
{
    public bool IsAuthenticated => true;

    public string UserName => "user@northwind.com";

    public string FullName => "User fake";
}
