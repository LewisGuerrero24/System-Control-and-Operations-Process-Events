package com.example.SFF.application.services;

import com.example.SFF.application.useCases.CustomerUseCase;
import com.example.SFF.domain.models.Customer;
import com.example.SFF.domain.ports.CustomerPorts;
import org.springframework.stereotype.Service;

@Service
public class CustomerServices implements CustomerUseCase {

    private final CustomerPorts customerPorts;

    public CustomerServices(CustomerPorts customerPorts) {
        this.customerPorts = customerPorts;
    }


    @Override
    public Customer findCustomer(Customer customer) {
        return customerPorts.findByCustomer(customer);
    }

}