using Microsoft.EntityFrameworkCore;
using se4.EFC.Models;
using Microsoft.EntityFrameworkCore;
namespace se4.EFC
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Ass4
            //using var context = new BankDbContext();
            //context.Database.EnsureCreated();

            //while (true)
            //{
            //    Console.Clear();
            //    Console.WriteLine("National Bank Management");
            //    Console.WriteLine("======================================");
            //    Console.WriteLine("1) Add a new Customer");
            //    Console.WriteLine("2) Open a new Account for a Customer");
            //    Console.WriteLine("3) Update Account Status (Active / Closed)");
            //    Console.WriteLine("4) Remove an Account from a Customer");
            //    Console.WriteLine("5) List all Customers (with accounts)");
            //    Console.WriteLine("0) Exit");
            //    Console.Write("\nEnter choice: ");

            //    string? choice = Console.ReadLine();

            //    switch (choice)
            //    {
            //        case "1":
            //            AddNewCustomer(context);
            //            break;
            //        case "2":
            //            OpenNewAccount(context);
            //            break;
            //        case "3":
            //            UpdateAccountStatus(context);
            //            break;
            //        case "4":
            //            RemoveAccountFromCustomer(context);
            //            break;
            //        case "5":
            //            ListAllCustomers(context);
            //            break;
            //        case "0":
            //            Console.WriteLine("Exiting application...");
            //            return;
            //        default:
            //            Console.WriteLine("Invalid choice. Please try again.");
            //            break;
            //    }

            //    Console.WriteLine("\nPress any key to return to the menu...");
            //    Console.ReadKey();
            //}


            //static void AddNewCustomer(BankDbContext context)
            //{
            //    Console.Clear();
            //    Console.WriteLine("Add New Customer");
            //    try
            //    {
            //        Console.Write("Full Name: ");
            //        string name = Console.ReadLine() ?? "";

            //        Console.Write("National ID: ");
            //        string natId = Console.ReadLine() ?? "";

            //        Console.Write("Date of Birth (yyyy-MM-dd): ");
            //        if (!DateTime.TryParse(Console.ReadLine(), out DateTime dob))
            //        {
            //            Console.WriteLine("Invalid date format.");
            //            return;
            //        }

            //        Console.Write("Email: ");
            //        string email = Console.ReadLine() ?? "";

            //        Console.Write("Phone: ");
            //        string phone = Console.ReadLine() ?? "";

            //        Console.Write("Address: ");
            //        string address = Console.ReadLine() ?? "";

            //        Console.WriteLine("Customer Type:\n1) Individual\n2) Business");
            //        Console.Write("Choice: ");
            //        int typeChoice = int.Parse(Console.ReadLine() ?? "1");
            //        CustomerType custType = typeChoice == 2 ? CustomerType.Business : CustomerType.Individual;

            //        var customer = new Customer
            //        {
            //            FullName = name,
            //            NationalId = natId,
            //            DateOfBirth = dob,
            //            Email = email,
            //            PhoneNumber = phone,
            //            Address = address,
            //            CustomerType = custType
            //        };

            //        context.Customers.Add(customer);
            //        context.SaveChanges();
            //        Console.WriteLine($"\nCustomer created successfully. CustomerId = {customer.Id}");
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine($"Error: {ex.Message}");
            //    }
            //}

            //static void OpenNewAccount(BankDbContext context)
            //{
            //    Console.Clear();
            //    Console.WriteLine("Open New Account");
            //    try
            //    {
            //        Console.Write("Account Number: ");
            //        string accNumber = Console.ReadLine() ?? "";

            //        Console.WriteLine("Account Type:\n1) Savings\n2) Current\n3) Business");
            //        Console.Write("Choice: ");
            //        int accTypeChoice = int.Parse(Console.ReadLine() ?? "1");
            //        AccountType accType = accTypeChoice switch { 2 => AccountType.Current, 3 => AccountType.Business, _ => AccountType.Savings };

            //        Console.Write("Branch Code: ");
            //        string branchCode = Console.ReadLine() ?? "";

            //        Console.Write("Customer Id: ");
            //        int customerId = int.Parse(Console.ReadLine() ?? "0");

            //        Console.WriteLine("Ownership Role:\n1) Primary\n2) CoHolder");
            //        Console.Write("Choice: ");
            //        int roleChoice = int.Parse(Console.ReadLine() ?? "1");
            //        OwnershipRole role = roleChoice == 2 ? OwnershipRole.CoHolder : OwnershipRole.Primary;

            //        Console.WriteLine($"\nValidating branch '{branchCode}' and customer #{customerId}...");

            //        var branch = context.Branches.Find(branchCode);
            //        var customer = context.Customers.Find(customerId);

            //        if (branch == null) { Console.WriteLine("Error: Branch does not exist."); return; }
            //        if (customer == null) { Console.WriteLine("Error: Customer does not exist."); return; }

            //        var account = context.Accounts.Find(accNumber);
            //        if (account == null)
            //        {
            //            account = new Account
            //            {
            //                AccountNumber = accNumber,
            //                AccountType = accType,
            //                BranchCode = branchCode,
            //                CurrentBalance = 0
            //            };
            //            context.Accounts.Add(account);
            //        }

            //        var customerAccount = new CustomerAccount
            //        {
            //            CustomerId = customerId,
            //            AccountNumber = accNumber,
            //            OwnershipType = role,
            //            AccountStatus = AccountStatus.Active
            //        };

            //        context.CustomerAccounts.Add(customerAccount);
            //        context.SaveChanges();

            //        Console.WriteLine($"Account '{accNumber}' created and linked to customer {customerId} as {role} owner.");
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine($"Error: {ex.Message}");
            //    }
            //}

            //static void UpdateAccountStatus(BankDbContext context)
            //{
            //    Console.Clear();
            //    Console.WriteLine("Update Account Status");
            //    try
            //    {
            //        Console.Write("Account Number: ");
            //        string accNumber = Console.ReadLine() ?? "";

            //        Console.Write("Customer Id: ");
            //        int customerId = int.Parse(Console.ReadLine() ?? "0");

            //        Console.WriteLine("New Status:\n1) Active\n2) Closed");
            //        Console.Write("Choice: ");
            //        int statusChoice = int.Parse(Console.ReadLine() ?? "1");
            //        AccountStatus newStatus = statusChoice == 2 ? AccountStatus.Closed : AccountStatus.Active;

            //        var custAccount = context.CustomerAccounts.Find(customerId, accNumber);
            //        if (custAccount == null)
            //        {
            //            Console.WriteLine("Error: Link between customer and account not found.");
            //            return;
            //        }

            //        custAccount.AccountStatus = newStatus;
            //        context.SaveChanges();
            //        Console.WriteLine($"Status updated to {newStatus}.");
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine($"Error: {ex.Message}");
            //    }
            //}

            //static void RemoveAccountFromCustomer(BankDbContext context)
            //{
            //    Console.Clear();
            //    Console.WriteLine("Remove Account From Customer");
            //    try
            //    {
            //        Console.Write("Account Number: ");
            //        string accNumber = Console.ReadLine() ?? "";

            //        Console.Write("Customer Id: ");
            //        int customerId = int.Parse(Console.ReadLine() ?? "0");

            //        var custAccount = context.CustomerAccounts.Find(customerId, accNumber);
            //        if (custAccount == null)
            //        {
            //            Console.WriteLine("Error: Link not found.");
            //            return;
            //        }

            //        context.CustomerAccounts.Remove(custAccount);
            //        context.SaveChanges();
            //        Console.WriteLine("Ownership link deleted.");

            //        bool hasOtherOwners = context.CustomerAccounts.Any(ca => ca.AccountNumber == accNumber);
            //        if (!hasOtherOwners)
            //        {
            //            var account = context.Accounts.Find(accNumber);
            //            if (account != null)
            //            {
            //                context.Accounts.Remove(account);
            //                context.SaveChanges();
            //                Console.WriteLine($"That was the last owner, account '{accNumber}' was also removed.");
            //            }
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine($"Error: {ex.Message}");
            //    }
            //}

            //static void ListAllCustomers(BankDbContext context)
            //{
            //    Console.Clear();
            //    Console.WriteLine("All Customers");

            //    var customers = context.Customers
            //        .Include(c => c.CustomerAccounts)
            //            .ThenInclude(ca => ca.Account)
            //                .ThenInclude(a => a.Branch)
            //        .ToList();

            //    foreach (var c in customers)
            //    {
            //        Console.WriteLine($"\n#{c.Id} {c.FullName} ({c.CustomerType})");

            //        if (!c.CustomerAccounts.Any())
            //        {
            //            Console.WriteLine("(no accounts)");
            //            continue;
            //        }

            //        foreach (var ca in c.CustomerAccounts)
            //        {
            //            var acc = ca.Account;
            //            Console.WriteLine($"{acc.AccountNumber} Current Balance: {acc.CurrentBalance:N2} {ca.OwnershipType} {ca.AccountStatus} @{acc.Branch?.Name}");
            //        }
            //    }
            //} 
            #endregion
        }
    }
}
