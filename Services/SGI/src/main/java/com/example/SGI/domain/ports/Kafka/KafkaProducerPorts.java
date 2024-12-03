package com.example.SGI.domain.ports.Kafka;

public interface KafkaProducerPorts {
    void kafkaProducerMessages(String topic,String messages);
}
