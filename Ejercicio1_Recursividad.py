# ============================================
# EJERCICIO 1 - RECURSIVIDAD
# ============================================

"""
Escribe una funcion recursiva que calcule la suma
de todos los numeros de un arreglo.

Ejemplo:
    Input: [1, 2, 3, 4, 5]
    Output: 15
"""

# Escribe tu funcion aqui:
def suma_recursiva(arreglo):
    # Caso base: arreglo vacio
    if len(arreglo) == 0:
        return 0
    # Caso recursivo: primer elemento + suma del resto
    return arreglo[0] + suma_recursiva(arreglo[1:])





# ============================================
# PRUEBAS - No modificar
# ============================================
if __name__ == "__main__":
    print(suma_recursiva([1, 2, 3, 4, 5]))  # Esperado: 15
    print(suma_recursiva([10, 20, 30]))     # Esperado: 60
    print(suma_recursiva([]))               # Esperado: 0
