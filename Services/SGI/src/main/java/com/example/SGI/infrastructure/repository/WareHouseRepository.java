package com.example.SGI.infrastructure.repository;

import com.example.SGI.domain.models.Customer;
import com.example.SGI.domain.models.WareHouse;
import org.springframework.data.jpa.repository.JpaRepository;

public interface WareHouseRepository extends JpaRepository<WareHouse,Long> {
}
