package main

// Definición de la estructura User
type User struct {
    Email string
    Age   int
    Name  string
    ID    int
}

// Función NewUser para crear una instancia de User
func NewUser(email string, age int, name string, id int) User {
    return User{
        Email: email,
        Age:   age,
        Name:  name,
        ID:    id,
    }
}

// func main() {
//     // Declaración de user dentro de la función main
//     user := NewUser(
//         "test@email.com",
//         24,
//         "Juan Perez",
//         1,
//     )
//     fmt.Println(user) // Output: {test@email.com 24 Juan Perez 1}
// }