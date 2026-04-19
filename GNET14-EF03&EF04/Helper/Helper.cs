using GNET14_EF03_EF04.Enums;
using GNET14_EF03_EF04.Migrations;
using GNET14_EF03_EF04.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Security.Principal;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace GNET14_EF03_EF04.Helper
{
    internal static class Helper
    {
       public static  int ValidateChoice(string Message)
        {
            while(true)
            {
                Console.WriteLine(Message);
                string input = Console.ReadLine();
                if(int.TryParse(input, out int choice))
                {
                    return choice;
                }
                Console.WriteLine("Invalid Choice!");
            }

        }
        public static string ValidateString(string Message)
        {
            while (true)
            {
                Console.WriteLine(Message);
                string input = Console.ReadLine();
                if(!string.IsNullOrEmpty(input))
                {
                    return input;
                }
                Console.WriteLine("Invalid input cannot be null");
            }
        }

        public static string ValidateEmail(string message)
        {
            while(true)
            {
                Console.WriteLine(message);
                string input = Console.ReadLine();
                if(!string.IsNullOrEmpty(input) && input.Contains('@') )
                {
                    return input;
                }
                Console.WriteLine("Invalid Email");
            }
        }

        public static string ValidatePhoneNumber(string message)
        {
            while (true)
            {
                Console.WriteLine(message);
                string input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input) && input.Length == 10 && input.All(char.IsDigit))
                {
                    return input;
                }
                Console.WriteLine("Invalid PhoneNumber");
            }
        }
        public static string ValidateNationalId(string message)
        {
            while(true)
            {
                Console.WriteLine(message);
                string input = Console.ReadLine();
                if(!string.IsNullOrEmpty(input) && input.Length ==14)
                {
                    return input;
                }
                Console.WriteLine("Invalid National Id");
            }
        }
        public static DateTime ValideDate(string message)
        {
            while(true)
            {
                Console.WriteLine(message);
                string input = Console.ReadLine();
                if(DateTime.TryParseExact(input, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None,
                out DateTime res))
                {
                    return res;
                }
                Console.WriteLine("Invalid date");
            }
        }
        public static CustomerType ValidateCustomerType()
        {
            while(true)
            {
                Console.WriteLine("Customer Type: ");
                Console.WriteLine("1) Individual");
                Console.WriteLine("2) Bussiness");
                Console.Write("Choice: ");
                string input = Console.ReadLine();
                if(int.TryParse(input, out int res)   && Enum.IsDefined(typeof(CustomerType) , res) )
                {
                    return (CustomerType)res;
                }
                Console.WriteLine("Invalid Type");
            }
        }
        public static AccountType ValidateAccountType()
        {
            while(true)
            {
                Console.WriteLine("Account Type:");
                Console.WriteLine("1) Saving");
                Console.WriteLine("2) Current");
                Console.WriteLine("3) Bussiness");
                Console.Write("Choice: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int res) && Enum.IsDefined(typeof(AccountType), res))
                {
                    return (AccountType)res;
                }
                Console.WriteLine("Invalid Type");

            }
        }
        public static OwnerShipType ValidateOwnerShip()
        {

            while (true)
            {
                Console.WriteLine("OwnerShip Role");
                Console.WriteLine("1) Primary");
                Console.WriteLine("2) CoHolder");
                Console.Write("Choice: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int res) && Enum.IsDefined(typeof(OwnerShipType), res))
                {
                    return (OwnerShipType)res;
                }
                Console.WriteLine("Invalid Type");
            }

        }
        public static  AccountStatus ValidateAccountStatus()
        {
            while (true)
            {
                Console.WriteLine("New Status");
                Console.WriteLine("1) Active");
                Console.WriteLine("2) Closed");
                Console.Write("Choice: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int res) && Enum.IsDefined(typeof(AccountStatus), res))
                {
                    return (AccountStatus)res;
                }
                Console.WriteLine("Invalid Type");
            }

        }
        public  static  void PauseMenue()
        {
            Console.WriteLine("Press any key to return to the menu...");
            Console.ReadKey();
        }
        public static void PrintSucess( string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        public static void PrintValidation(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        public static int  ValidateAccountCode(string message)
        {
            
            while (true)
            {
                Console.WriteLine(message);
                string input = Console.ReadLine();
               
                if(int.TryParse(input, out int res) )
                {
                   
                    
                        return res;
                    
                   


                }
                Console.WriteLine("Invalid Account Code");

            }

        }
        public static int ValidateBranchCode(string message)
        {
            
            while (true)
            {
                Console.WriteLine(message);
                string input = Console.ReadLine();

                if (int.TryParse(input, out int res))
                {
                    
                  
            
                        return res;
                  


                }
                Console.WriteLine("Invalid Branch Code");

            }

        }

        public static int ValidateCustomerId(string message)
        {
           
            while (true)
            {
                Console.WriteLine(message);
                string input = Console.ReadLine();

                if (int.TryParse(input, out int res))
                {
                    
                  
                    return res;
                  
                    


                }
                Console.WriteLine("Invalid Customer Id ");

            }

        }

        public static bool ValidateCustomerExists(int CustomerId)
        {
            using var db = new DBContextBankApp();
          var x =  db.Set<Customer>().Find(CustomerId);
            return x is not null;
        }

        public static bool ValideBranchExists(int BC)
        {
            using var dbcontext = new DBContextBankApp();
            Branch x = dbcontext.Set<Branch>().Find(BC);
            if(x is not null)
            {
                return true;
            }
            return false;
           
        }

        public static (bool , int ) ValideAccountCodeLinkedToAccount(int AC)
        {
            using var dbcontext = new DBContextBankApp();
            Account x  = dbcontext.Set<Account>().FirstOrDefault(x =>x.AccountCode ==AC);
            if (x is not null)
            {
                return (true,x.AccountNumber);
            }
            return(false,0);


        }




        public static void  AddCustomer()
        {
            using var dbcontext = new DBContextBankApp();
            Console.Clear();
            Console.WriteLine("-- Add New Customer --");
            string FullName = ValidateString("Full Name: ");
            string NationalId = ValidateNationalId("National Id: ");
            DateTime DOB = ValideDate("Date Of Birth: (yyyy-MM-dd)");
            string Email = ValidateEmail("Email: ");
            string Phone = ValidatePhoneNumber("Phone Number: ");
            string Address = ValidateString("Address: ");
            CustomerType type = ValidateCustomerType();
            var customer = new Customer()
            {
                FullName = FullName,
                NationalId = NationalId,
                DateOfBirth = DOB,
                Email = Email,
                PhoneNumber = Phone,
                Address = Address,
                CustomerType = type
                
            };
            dbcontext.Set<Customer>().Add(customer);
            int cnt = dbcontext.SaveChanges();
            if (cnt != 0)
            {
                PrintSucess($"Customer Created Sucessfully. Customer Id = {customer.Id}");
                PauseMenue();
            }
            





        }

        public static void OpenAccount()
        {
            using var dbcontext = new DBContextBankApp();
            Console.Clear();
            Console.WriteLine("== Open a new Account ==");
            int AccountCode = ValidateAccountCode("Account Number:");
            AccountType type = ValidateAccountType();
            int BranchCode = ValidateBranchCode("Branch Code: ");

            int CustomerId = ValidateCustomerId("Customer Id: ");
            OwnerShipType ownerShipType = ValidateOwnerShip();

            PrintValidation($"Validating Branch \' {BranchCode}\' and customer #{CustomerId}");
           
            AccountCustomer Accountx;
            if (ValideBranchExists(BranchCode) && ValidateCustomerExists(CustomerId) )
            {

                Account Account = new Account
                {
                    AccountCode = AccountCode,
                    AccountType = type,
                    OwnerShipType = ownerShipType,
                   BranchId = BranchCode,
                   

                };
                dbcontext.Set<Account>().Add(Account);
                dbcontext.SaveChanges();
                Accountx = new AccountCustomer
                {
                    AccountId = Account.AccountNumber ,
                    CustomerId = CustomerId,
                    OwnerShipType = ownerShipType,
                    AccountStatus= AccountStatus.Active




                };
                dbcontext.Add(Accountx);
                int cnt = dbcontext.SaveChanges();
                if (cnt != 0)
                {
                    PrintSucess($"Account {AccountCode} Created and linked to Customer #{CustomerId} As {ownerShipType}");
                    PauseMenue();
                }



            }
            else
            {
                Console.WriteLine("This customer or this branch doesnot exist.");
            }







        }
        public static void UpdateAccountStatus()
        {
            using var db = new DBContextBankApp();
            Console.WriteLine("==== Update Account Status ===");
            int AccountCode = ValidateAccountCode("Account Number:");
            int CustomerId = ValidateCustomerId("Customer Id: ");

            AccountStatus newStatus = ValidateAccountStatus();
            (bool exists, int AccountNum) = ValideAccountCodeLinkedToAccount(AccountCode);
            AccountCustomer x;
            if (exists)
            {
                x = new AccountCustomer()
                {
                    AccountId = AccountNum,
                    CustomerId = CustomerId,
                    AccountStatus = newStatus
                };
                db.Update(x);  
            }
            int cnt = db.SaveChanges();     
            if(cnt !=0)
            {
                PrintSucess($"Status Updated to {newStatus}");
                PauseMenue();
            }
            






        }

        public static void RemoveAccountFromCustomer()
        {
            using var db = new DBContextBankApp();
            Console.WriteLine("===== Remove Account from customer====");
            int AccountCode = ValidateAccountCode("Account Number: ");
            int CustomerId = ValidateCustomerId("Customer Id: ");
            (bool exists, int AccountNumber) = ValideAccountCodeLinkedToAccount(AccountCode);
            if (ValidateCustomerExists(CustomerId) &&  exists)
            {

              AccountCustomer x = db.Set<AccountCustomer>().Find(CustomerId, AccountNumber);
                db.Remove(x);
              int cnt =  db.SaveChanges();
                if (cnt !=0)
                {
                    PrintSucess("OwnerShip Link deleted");
                    AccountCustomer search = db.Set<AccountCustomer>().FirstOrDefault(x => x.AccountId == AccountNumber);
                    if (search is null)
                    {
                        Account account = db.Set<Account>().Find(AccountNumber);
                        db.Remove(account);
                        db.SaveChanges();
                        
                        PrintValidation($"That was the last owner - account {AccountNumber} was also removed");
                    }
                    PauseMenue();

                }

              




            }


        }

        public static void ListCustomers()
        {
            using var dbcontext = new DBContextBankApp();
            var customers = dbcontext.Set<Customer>().Include(c => c.AccountCustomers).ThenInclude(AC => AC.Account).ThenInclude(A => A.Branch);
            foreach (Customer customer in customers)
            {
                Console.WriteLine($"#{customer.Id}  {customer.FullName}({customer.CustomerType})");
                if (customer.AccountCustomers.Any())
                {
                    foreach (var accuntcust in customer.AccountCustomers)
                    {
                        Console.WriteLine($"{accuntcust.Account.AccountNumber}-{accuntcust.Account.AccountType}    Balance = {accuntcust.Account.CurrentBalance}   {accuntcust.Account.OwnerShipType}  {accuntcust.AccountStatus}  @{accuntcust.Account.Branch.Name}");
                    }
                }
                else
                {
                    Console.WriteLine("(No Accounts)");
                }
            }

            PauseMenue();
        }
    }
}
