﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestionPPM.Repositorios
{
    public static class Mensajes
    {
        public static string MensajeTransaccionExitosa = "Transacción realizada exitosamente.";
        public static string MensajeTransaccionFallida = "Transacción fallida.";
        public static string MensajeNoDataListado = "No se encontraron resultados.";
        public static string MensajeDatosObligatorios = "Los campos con * son de ingreso obligatorio.";
        public static string MensajeCedulaRucIncorrecto = "Cédula RUC incorrecto.";
        public static string MensajeValidacionCedulaRucRegistrado = "La Cédula o RUC ya se encuentra registrado.";
        public static string MensajeCorreoIncorrecto = "Email incorrecto.";
        public static string MensajeResgistroExistente = "El registro ya existente en el sistema.";
        public static string MensajeValidacionNombreTarifario = "Tarifario existente.";
        public static string MensajeValidacionNombreRol = "Rol existente.";
        public static string MensajeValidacionNombreRolRequerido = "Rol existente.";
        public static string MensajeValidacionContrasenias = "Las contraseñas ingresadas no coinciden.";
        public static string MensajeCredencialesIncorrectas = "Nombre de usuario o contraseña incorrecta.";
        public static string MensajeLongitudContrasenia = "La contraseña debe tener mìnimo 8 caracteres.";
        public static string MensajeUsuarioNoExiste = "El usuario ingresado no se encuentra registrado en el sistema.";
        public static string MensajeValidacionContraseniaActual = "La contraseña actual ingresada es incorrecta.";
        public static string MensajeCatalogoNoDisponible = "Catálogo no disponible.";
        public static string MensajeEmailExistenteAsociadoUsuario = "El email ya se encuentra asocidado a un usuario.";
        public static string MensajeEmailExistenteAsociadoContacto = "El email ya se encuentra asocidado a un contacto.";
        public static string MensajeValidacionTipoTarifaFijo = "El valor del tarifario de tipo fijo tiene que ser mayor que 0";
        public static string MensajeCodigoCotizacionError = "El Código de Cotización no pudo ser generado.";
        public static string MensajeValidacionPagosCodigoCotizacion = "Total de los pagos parciales incorrecto.";
        public static string MensajeValidacionPago1 = "El valor del primer pago tiene que ser mayor a cero.";
        public static string MensajeRecuperacionClave = "La nueva contraseña fue enviada al correo registrado";
        public static string MensajeCodigoVendedor = "Código de vendedor ya registrado en el sistema";
        public static string MensajeCambioContaseña = "La contraseña nueva debe ser diferente a la contraseña actual";
        public static string MensajeValidacionContraseniaActualOffice = "La contraseña ingresada no coincide con la constraseña de su correo";
        public static string MensajeValidacionNombreImpuesto = "Impuesto existente.";
        public static string MensajeValidacionEntregables = "No se puede crear una cotización sin detalle de entregables.";

        public static string MensajeValidacionCorreoExistenteContactos = "No se puede verificar el correo del contacto sin especificar el tipo.";

        public static string MensajeCargaMasivaExitosa = "La carga masiva fue realizada exitosamente.";
        public static string MensajeCargaMasivaFallida = "La carga masiva no se pudo realizar. Revisar errores o la estructura del archivo.";

        public static string MensajeCargaMasivaSinRegistros = "No se encontraron registros a cargar.";
        public static string MensajeValidacionCodigoCotizacionContactosCliente = "Existen contactos que no se encuentran asociados a clientes.";
        public static string MensajeValidacionCodigoCotizacionRegistrado = "El código de cotización ya se encuentra registrado.";

        public static string MensajeValidacionCodigoCotizacionCargaMasiva = "El código de cotización requiere al menos una sublínea de negocio y un contacto.";
        public static string MensajeValidacionCodigoCotizacionSublineaNegocioCargaMasiva = "No se encontró la Sublínea de negocio.";
        public static string MensajeValidacionCodigoCotizacionContactoFacturacionCargaMasiva = "El contacto no es de facturación.";
        public static string MensajeValidacionExistenciaPrefijo = "Prefijo inexistente.";

        public static string MensajeValidacionNotificacionEnviada = "No se pueden cancelar notificaciones que ya han sido enviadas.";

        public static string MensajeAdjuntoExitoso = "El archivo fue adjuntado exitosamente.";
        public static string MensajeAdjuntoFallido = "El archivo no pudo ser adjuntado.";

        public static string MensajeClienteInexistente = "No existe un cliente asociado.";

        public static string MensajeAdjuntoEliminadoExitosamente = "El archivo {0} fue eliminado exitosamente.";
        public static string MensajeAdjuntoEliminadoFallido = "El archivo {0} no pudo ser eliminado.";

        public static string MensajeCodigoActaError = "El Código del Acta no pudo ser generado.";

        public static string MensajeActaReunionSuspendida = "Se suspende.";
        public static string MensajeActaActualizacionSecuencial = "Ocurrió un error en el código del acta.";

        public static string MensajeValidacionRangoFechasInicioFin = "La fecha de inicio no puede ser mayor a la fecha de finalización.";
        public static string MensajeValidacionFechaEntrega = "La fecha de inicio no puede ser mayor a la fecha de entrega.";

        public static string MensajeValidacionSublineaNegocioExistente = "La Sublínea de negocio ya se encuentra registrada.";
        public static string MensajeValidacionTipoRequerimientoExistente = "El tipo de requerimiento o solicitud ya se encuentra registrado.";

        public static string MensajeValidacionRangoHoraInicioFin = "La hora de inicio no puede ser mayor a la hora de finalización.";
        public static string MensajeValidacionRangoHoraInicioFinDiferente = "La hora de inicio no puede ser igual a la hora de finalización.";

        public static string MensajeDatosObligatoriosTelefono = "Favor Ingresar un número de contacto.";
         
        public static string MensajeValidacionRangoFechasFinEntrega = "La fecha de entrega no puede ser menor a la fecha de finalización";
        public static string MensajeValidacionRangoFechasInicioEntrega = "La fecha de entrega no puede ser menor a la fecha de inicio";

        public static string MensajeValidacionDetallePendiente = "Tiene un detalle pendiente de agregar."; 

        public static string MensajeValidacionNombreBodega = "Nombre de la bodega ya existe en el sistema.";
        public static string MensajeValidacionCodigoBodega = "Código de la bodega ya existe en el sistema.";

        public static string MensajeValidacionCodigoProductoExistente = "El código de producto ya se encuentra registrado.";

        public static string MensajeValidacionCodigoProductoGestorExistente = "El producto gestor ya se encuentra registrado.";

        //Impresión masiva
        public static string MensajeErrorImpresionMasiva = "Ocurrió un error. No se pudo generar el archivo consolidado.";

        //Seleccionar un elemento
        public static string MensajeErrorSeleccionVacia = "Seleccione un item.";
        public static string MensajeErrorItemRepetido = "El ítem ya fue agregado.";
        public static string MensajeErrorItemsRepetidos = "Existen ítems duplicados. Por favor, verificar los detalles.";

        public static string MensajeArchivoNoExiste = "No se pudo encontrar el archivo.";

        public static string MensajeClienteNoExiste = "Cliente no existe en el Sistema Contable.";

        public static string MensajeProductoNoExiste = "El Producto no existe en el Sistema Contable.";

        public static string MensajeClienteConsolidacionInexistente = "El cliente {0} no se encuentra registrado.";

        public static string MensajeExcepcionNLOG = "Se inició una excepción durante la ejecución de la aplicación.";

        public static string MensajeValidacionPresupuestoActaCliente = "El presupuesto tiene que encontrarse en un Acta de Cliente.";

        public static string MensajeLímiteComentario = "Límite(5) de comentarios en la solicitud excedido.";

        public static string MensajeRespuestaRequerida= "Por favor ingrese una Respuesta.";

        public static string MensajeRespuestaLimiteCaracteres = "Límite de caracteres excedido. Por favor vuelva a ingresar respuesta";

        public static string MensajeRespuestaSesionExpirada = "Sesión expirada. Actualice la página por favor.";

        public static string MensajeIdentificacionIncorrecto = "Identificación {0} incorrecta.";

        public static string MensajeEmailIncorrecto = "Email {0} incorrecto.";
    }
}