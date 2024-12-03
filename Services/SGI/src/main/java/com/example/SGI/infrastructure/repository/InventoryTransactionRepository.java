package com.example.SGI.infrastructure.repository;

import com.example.SGI.domain.models.InventoryTransaction;
import org.springframework.data.jpa.repository.JpaRepository;

public interface InventoryTransactionRepository extends JpaRepository<InventoryTransaction,Long> {
}
