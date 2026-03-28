#!/bin/bash

# --- SCRIPT DE EJECUCIÓN PARA LINUX (ZORINOS) ---
# Este script te permite ejecutar cada ejemplo de SOLID/STUPID de forma independiente.

echo "=========================================================="
echo "    GESTOR DE EJECUCIÓN - SOLID/STUPID PROJECTS           "
echo "=========================================================="
echo "Seleccioná el proyecto que querés correr:"
echo ""
echo "1) 1.SRP (Single Responsibility Principle)"
echo "2) 2.ISP (Interface Segregation Principle)"
echo "3) 3.DIP (Dependency Inversion Principle)"
echo "4) 4.Principio (Open/Closed - Adapter Pattern)"
echo "5) LSP (Liskov Substitution Principle)"
echo "6) STUPID (Ejemplo de Código Mal Diseñado)"
echo "7) Salir"
echo ""

read -p "Ingresá una opción [1-7]: " opcion

case $opcion in
    1)
        echo "Ejecutando SRP..."
        cd "1.SRP/CleanTeeth/SOLIDPrinciples" && dotnet run
        ;;
    2)
        echo "Ejecutando ISP..."
        cd "2.ISP/CleanTeeth/SOLIDPrinciples" && dotnet run
        ;;
    3)
        echo "Ejecutando DIP..."
        cd "3.DIP/CleanTeeth/SOLIDPrinciples" && dotnet run
        ;;
    4)
        echo "Ejecutando 4.Principio..."
        cd "4Principio/CleanTeeth/SOLIDPrinciples" && dotnet run
        ;;
    5)
        echo "Ejecutando LSP..."
        cd "LSP/CleanTeeth/SOLIDPrinciples" && dotnet run
        ;;
    6)
        echo "Ejecutando STUPID..."
        cd "STUPID/CleanTeeth/SOLIDPrinciples_STUPID" && dotnet run
        ;;
    7)
        echo "¡Chau!"
        exit 0
        ;;
    *)
        echo "Opción no válida loco, ponete las pilas."
        ;;
esac

# Volver a la raíz por si acaso
cd ../../..
