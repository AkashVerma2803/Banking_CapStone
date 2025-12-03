using Banking_CapStone.Service;

namespace Banking_CapStone.Data
{
    public static class DatabaseSeeder
    {
        private static readonly PasswordHasher _passwordHasher = new PasswordHasher();

        public static readonly string SuperAdminPasswordHash = "100000.Z99C/OvzNeLO3OA0GiirHQ==.vzyX10fSzZGjQQb5cAv1ONnVW52HkhOWHMNhLbM2udI=";
        public static readonly string BankUserPasswordHash = "100000.Rhxk8Ie+cgBtroK88pKBhw==.cyLg+f5S9PoO+4S/hLqz2USvhVhzO2bah9ETgK6A6nE=";
        public static readonly string ClientPasswordHash = "100000.e4t4587m+1yRkgJsD0QeEg==.ZO93gkE38xLxUA3FmBul8dY5eF5o7ZFSE6R1PkIJSu4=";
        public static readonly DateTime SeedDate = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc);
    }
}