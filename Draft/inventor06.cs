using System;
using System.Collections.Generic;

public class Dashboard
{
    public List<Widget> Widgets { get; set; }
    private Dictionary<string, Action> menuActions;

    public Dashboard()
    {
        // Initialize the Widgets list in the constructor
        Widgets = new List<Widget>();
        menuActions = new Dictionary<string, Action>();
    }

    public void AddWidget(Widget widget)
    {
        // Implementation to add a widget to the dashboard
        Widgets.Add(widget);
    }

    public void RemoveWidget(Widget widget)
    {
        // Implementation to remove a widget from the dashboard
        Widgets.Remove(widget);
    }

    public void AddMenuItem(string menuItemText, Action action)
    {
        // Add a menu item with a corresponding action
        menuActions[menuItemText] = action;
    }

    public void NavigateTo(MenuItem menuItem)
    {
        // Implementation to navigate to a menu item
        // This method switches between screens or views based on the selected menu item.

        if (menuActions.ContainsKey(menuItem.Text))
        {
            // Check if the selected menu item has a corresponding action
            Console.Clear(); // Clear the terminal screen

            // Perform the action associated with the selected menu item
            menuActions[menuItem.Text].Invoke();
        }
        else
        {
            Console.WriteLine($"Invalid menu item: '{menuItem.Text}'");
        }
    }
}


public class ProductManagement
{
    public int ProductID { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public string Category { get; set; }
    public int StockQuantity { get; set; }

    public void AddProduct()
    {
        // Implementation to add a product
    }

    public void EditProduct()
    {
        // Implementation to edit a product
    }

    public void DeleteProduct()
    {
        // Implementation to delete a product
    }

    public List<Product> ListProducts()
    {
        // Implementation to list products
        return new List<Product>();
    }

    public List<Product> SearchProducts(string query)
    {
        // Implementation to search for products
        return new List<Product>();
    }
}

public class InventoryTracking
{
    public Product Product { get; set; }
    public int Quantity { get; set; }

    public void UpdateQuantity()
    {
        // Implementation to update product quantity
    }

    public int GetQuantity()
    {
        // Implementation to get product quantity
        return 0;
    }

    public void SetThreshold(int threshold)
    {
        // Implementation to set a threshold
    }

    public int GetThreshold()
    {
        // Implementation to get the threshold
        return 0;
    }
}

// public class SalesManagement
// {
//     public int SaleID { get; set; }
//     public DateTime Date { get; set; }
//     public Customer Customer { get; set; }
//     public List<Product> Products { get; set; }
//     public decimal TotalAmount { get; set; }

//     public void CreateSale()
//     {
//         // Implementation to create a sale
//     }

//     public void AddProductToSale()
//     {
//         // Implementation to add a product to a sale
//     }

//     public decimal CalculateTotal()
//     {
//         // Implementation to calculate the total amount
//         return 0;
//     }

//     public Invoice GenerateInvoice()
//     {
//         // Implementation to generate an invoice
//         return new Invoice();
//     }
// }
//
//
//
// public class SupplierManagement
// {
//     public int SupplierID { get; set; }
//     public string Name { get; set; }
//     public string ContactInfo { get; set; }
//     public List<Product> Products { get; set; }

//     public void AddSupplier()
//     {
//         // Implementation to add a supplier
//     }

//     public void EditSupplier()
//     {
//         // Implementation to edit a supplier
//     }

//     public void DeleteSupplier()
//     {
//         // Implementation to delete a supplier
//     }

//     public List<Supplier> ListSuppliers()
//     {
//         // Implementation to list suppliers
//         return new List<Supplier>();
//     }

//     public List<Supplier> SearchSuppliers(string query)
//     {
//         // Implementation to search for suppliers
//         return new List<Supplier>();
//     }
// // }
//
//
//
//
// public class ReportingAndAnalytics
// {
//     public string ReportType { get; set; }
//     public object Data { get; set; }

//     public Report GenerateReport()
//     {
//         // Implementation to generate a report
//         return new Report();
//     }

//     public void ExportReport(string format)
//     {
//         // Implementation to export a report
//     }
// }


public class SearchAndFilter
{
    public string SearchQuery { get; set; }
    public List<Filter> Filters { get; set; }

    public List<SearchResult> Search(string query)
    {
        // Implementation to search based on the query
        return new List<SearchResult>();
    }

    public List<SearchResult> ApplyFilter(Filter filter)
    {
        // Implementation to apply a filter
        return new List<SearchResult>();
    }

    public void ClearFilters()
    {
        // Implementation to clear applied filters
    }
}
