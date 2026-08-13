# Practica 4: Windows Forms

Proyecto desarrollado como parte de la asignatura Programación Básica, sesión "Interfaces Gráficas con Windows Forms y C#".

**Docente:** Gamalier Reyes del Carmen

**Integrantes del grupo:**

Adian Ortega Castro (2025-0118)
Hector Enyer Rodriguez (2025-0274)
Sebastian Mazara (2024-2723)


**Descripción:**

Es un conjunto de formularios hechos en C# que ponen en práctica el manejo de controles básicos digase el TextBox, ComboBox, Label, Button, ListBox, CheckBox, RadioButton, ademas de el patrón de eventos a validación de datos ingresados por el usuario. Se desarrollaron los 4 ejercicios propuestos en clase.

# 1. Conversor de unidades (Básico)

Formulario que permite convertir entre kilómetros/millas o °C/°F.

Controles:

Control	Nombre sugerido	Uso
TextBox	txtValor	Valor numérico a convertir
ComboBox	cmbUnidad	Selección de conversión (km→millas, millas→km, °C→°F, °F→°C)
Button	btnConvertir	Ejecuta el cálculo
Label	lblResultado	Muestra el resultado

Datos que procesa: valida que txtValor sea numérico (double.TryParse) antes de convertir; aplica la fórmula correspondiente según la opción elegida en cmbUnidad.

# 2. Control de asistencia (Intermedio)

Formulario que registra qué estudiantes de una lista están presentes.

Controles:

Control	Nombre sugerido	Uso
ListBox	lstEstudiantes	Lista de estudiantes del curso
CheckBox	chkPresente	Marca si el estudiante seleccionado está presente
Button	btnGenerarResumen	Genera el resumen de asistencia
Label / TextBox multilinea	lblResumen	Muestra el resumen final

Datos que procesa: recorre lstEstudiantes y determina, por cada estudiante marcado, quiénes asistieron; genera un conteo total de presentes/ausentes.

# 3. Menú del colmado (Intermedio)

Formulario que calcula el total de una compra según producto, cantidad y forma de pago.

Controles:

Control	Nombre sugerido	Uso
ComboBox	cmbProducto	Lista de productos con su precio
TextBox	txtCantidad	Cantidad a comprar
RadioButton	rdbEfectivo / rdbTarjeta	Forma de pago
Label	lblTotal	Muestra el total calculado

Datos que procesa: valida que txtCantidad sea un número entero válido (int.TryParse); calcula total = precio * cantidad; puede aplicar un recargo o descuento distinto según el método de pago seleccionado.

# 4. Registro de clientes (Avanzado)

Formulario que valida y acumula datos de clientes en una lista visible.

Controles:

Control	Nombre sugerido	Uso
TextBox	txtNombre, txtTelefono, txtCorreo	Datos del cliente
Button	btnRegistrar	Valida y agrega el cliente a la lista
ListBox	lstClientes	Acumula los clientes registrados

Datos que procesa: valida que ningún campo esté vacío, que el teléfono tenga formato numérico y que el correo contenga @; si todo es válido, agrega el registro a lstClientes con Items.Add(...) y limpia el formulario.

Patrón general aplicado en todos los ejercicios
Controles nombrados con prefijo según su tipo (txt, btn, lbl, cmb, chk, rdb, lst), tal como se explicó en clase.
Validación antes de procesar: se usa TryParse para campos numéricos y string.IsNullOrWhiteSpace para campos de texto obligatorios, evitando excepciones no controladas.
Patrón evento–manejador: toda la lógica se dispara desde el evento Click del botón correspondiente, conectado mediante doble clic en el diseñador.
Resultado visible al usuario: mediante Label.Text para resultados en pantalla, o MessageBox.Show(...) para advertencias y confirmaciones.
Capturas de pantalla

(Agregar aquí una captura de cada formulario en ejecución, mostrando un caso exitoso y un caso de validación fallida, por ejercicio).

Cómo ejecutar
Abrir la solución en Visual Studio (requiere el workload de desarrollo de escritorio .NET).
Compilar (Ctrl+Shift+B).
Ejecutar (F5) y probar cada formulario desde el menú principal (si se implementó uno) o abriendo cada Form de forma individual.
Criterios de evaluación cubiertos
 El formulario compila y ejecuta sin errores.
 Los controles tienen nombres descriptivos con los prefijos indicados.
 Se valida la entrada del usuario antes de procesarla.
 Los eventos responden correctamente a la interacción (clic, selección).
 El resultado se muestra con claridad al usuario (Label o MessageBox).
