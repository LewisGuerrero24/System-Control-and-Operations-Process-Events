package com.example.SFF.infrastructure.adapters;

import com.example.SFF.domain.models.Customer;
import com.example.SFF.domain.ports.CustomerPorts;
import com.example.SFF.infrastructure.repository.CustomerRepository;

public class CustomerRepositoryImple implements CustomerPorts {

    private final CustomerRepository CustomerJpaRepository;

    public CustomerRepositoryImple(CustomerRepository customerJpaRepository) {
        CustomerJpaRepository = customerJpaRepository;
    }


    @Override
    public Customer findByCustomer(Customer customer) {
        return customer;
    }
}