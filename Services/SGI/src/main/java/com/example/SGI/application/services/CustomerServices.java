package com.example.SGI.application.services;

import com.example.SGI.application.useCases.CustomerUseCase;
import com.example.SGI.domain.models.Customer;
import com.example.SGI.domain.ports.CustomerPorts;
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
