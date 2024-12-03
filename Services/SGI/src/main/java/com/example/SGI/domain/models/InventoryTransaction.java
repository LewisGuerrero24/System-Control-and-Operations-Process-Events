package com.example.SGI.domain.models;


import jakarta.persistence.*;

import java.time.LocalDate;
import java.util.Date;

@Entity
@Table(name = "InventoryTransactions")
public class InventoryTransaction extends Auditable {

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;

    private TypeTransaction typeTransaction;

    private int quantity;

    private LocalDate DateTransaction;

    private String Description;

    private String reason;

    private int userTransaction;

    @ManyToOne
    @JoinColumn(name = "product_id", nullable = false)
    private Product product;

    public InventoryTransaction(Long id, TypeTransaction typeTransaction, int quantity, LocalDate dateTransaction, String description, String reason, int userTransaction, Product product) {
        this.id = id;
        this.typeTransaction = typeTransaction;
        this.quantity = quantity;
        DateTransaction = dateTransaction;
        Description = description;
        this.reason = reason;
        this.userTransaction = userTransaction;
        this.product = product;
    }

    public Long getId() {
        return id;
    }

    public void setId(Long id) {
        this.id = id;
    }

    public TypeTransaction getTypeTransaction() {
        return typeTransaction;
    }

    public void setTypeTransaction(TypeTransaction typeTransaction) {
        this.typeTransaction = typeTransaction;
    }

    public int getQuantity() {
        return quantity;
    }

    public void setQuantity(int quantity) {
        this.quantity = quantity;
    }

    public LocalDate getDateTransaction() {
        return DateTransaction;
    }

    public void setDateTransaction(LocalDate dateTransaction) {
        DateTransaction = dateTransaction;
    }

    public String getDescription() {
        return Description;
    }

    public void setDescription(String description) {
        Description = description;
    }

    public String getReason() {
        return reason;
    }

    public void setReason(String reason) {
        this.reason = reason;
    }

    public int getUserTransaction() {
        return userTransaction;
    }

    public void setUserTransaction(int userTransaction) {
        this.userTransaction = userTransaction;
    }

    public Product getProduct() {
        return product;
    }

    public void setProduct(Product product) {
        this.product = product;
    }
}
