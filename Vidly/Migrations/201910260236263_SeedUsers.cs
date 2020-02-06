namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"

INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'e45334ba-a70d-4bf6-8d13-3738d662e9e6', N'admin@vidly.com', 0, N'AKk/BnKRaBiyzAXuzDlDgluQbz3EG0FlmddQK/mdsCnfDyvJHcJiZOXLfE6b2FWtrA==', N'2d4b84ac-67d1-4355-aad2-5de7289a0dd2', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'f6c41a62-f2b1-4012-9b13-fbea7fcc66a0', N'gust@vidly.com', 0, N'AJBNXJaJiw5FdnyVHC6WZX3vv0CeaOcqjgSBpR8PnOUzuHVuls6xum1kgf7VQ/eSJA==', N'0c9e8366-9101-4c44-9a25-6ad2da215259', NULL, 0, 0, NULL, 1, 0, N'gust@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'b9948f2c-961a-49ea-bf69-36230c19bb83', N'CanManageMovie')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'e45334ba-a70d-4bf6-8d13-3738d662e9e6', N'b9948f2c-961a-49ea-bf69-36230c19bb83')

");
        }
        
        public override void Down()
        {
        }
    }
}
