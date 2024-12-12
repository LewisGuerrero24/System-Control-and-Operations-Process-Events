package com.example.SGI.domain.models;


import jakarta.persistence.Column;
import jakarta.persistence.Entity;
import jakarta.persistence.Id;
import jakarta.persistence.Table;

@Entity
@Table(name = "Customer")
public class Customer {

    @Id
    private long id;
    @Column(name = "nombre", nullable = false)
    private String nombre;
    @Column(name = "email", nullable = false)
    private String Email;

    public Customer(long id, String nombre, String email) {
        this.id = id;
        this.nombre = nombre;
        Email = email;
    }

    public long getId() {
        return id;
    }

    public void setId(long id) {
        this.id = id;
    }

    public String getNombre() {
        return nombre;
    }

    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    public String getEmail() {
        return Email;
    }

    public void setEmail(String email) {
        Email = email;
    }
}
