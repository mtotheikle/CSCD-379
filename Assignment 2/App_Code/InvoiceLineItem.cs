using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// @author Michael Willams
/// Assignment 2
/// Main class for representing a invoice line item
[Serializable]
public class InvoiceLineItem
{
    /**
     * Shipping rate that is used to calcualate the shipping cost
     * based on the line items weight and qty
     */
    const double SHIPPING_RATE = 0.89;

    private int id;
    private Customer customer;
    private int orderId;
    private string itemSku;
    private string itemDesc;
    private int qty;
    private double unitPrice;
    private double unitWeight;

    public InvoiceLineItem(int id, Customer customer, int orderId, 
        string itemSku, string itemDesc, int qty, double unitPrice, double unitWeight)
    {
        this.id = id;
        this.customer = customer;
        this.orderId = orderId;
        this.itemSku = itemSku;
        this.itemDesc = itemDesc;
        this.qty = qty;
        this.unitPrice = unitPrice;
        this.unitWeight = unitWeight;
    }

    public int Id
    {
        get { return id; }
        set { id = value; }
    }

    public Customer Customer
    {
        get { return customer; }
        set { customer = value; }
    }

    public int OrderId
    {
        get { return orderId; }
        set { orderId = value; }
    }

    public string ItemSku
    {
        get { return itemSku; }
        set { itemSku = value; }
    }

    public string ItemDesc
    {
        get { return itemDesc; }
        set { itemDesc = value; }
    }

    public int Qty
    {
        get { return qty; }
        set { qty = value; }
    }

    public double UnitPrice
    {
        get { return unitPrice; }
        set { unitPrice = value; }
    }

    public double UnitWeight
    {
        get { return unitWeight; }
        set { unitWeight = value; }
    }

    public double calcShippingCost()
    {
        return ((this.unitWeight * this.qty) * SHIPPING_RATE);
    }

    public string ToString()
    {
        return "ID: " + this.id + 
            "<br />Customer: " + this.Customer.ToString() +
            "<br />Order Id: " + this.orderId +
            "<br />Item SKU: " + this.itemSku +
            "<br />Item Desc: " + this.itemDesc +
            "<br />Qty: " + this.qty + 
            "<br />Unit Price: " + this.unitPrice +
            "<br />Unit Weight: " + this.unitWeight;
    }
}