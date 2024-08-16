document.addEventListener("DOMContentLoaded", function() {
    const events = document.querySelectorAll(".event");
    const eventDetails = document.getElementById("event-details");

    events.forEach(event => {
        event.addEventListener("click", function() {
            const description = this.getAttribute("data-description");
            eventDetails.textContent = description || "Detalles no disponibles.";
        });
    });
});
