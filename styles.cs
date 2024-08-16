body {
    margin: 0;
    padding: 0;
    background-color: #1e1e2f;
    color: #ffffff;
    font-family: 'Roboto', sans-serif;
    display: flex;
    justify-content: center;
    align-items: center;
    min-height: 100vh;
}

.container {
    width: 90%;
    max-width: 1200px;
    text-align: center;
}

h1 {
    font-family: 'Montserrat', sans-serif;
    font-size: 2.5em;
    color: #f39c12;
    margin-bottom: 40px;
    text-transform: uppercase;
}

.timeline-events {
    display: flex;
    flex-direction: column;
    gap: 20px;
    align-items: center;
}

.event {
    background-color: #282846;
    padding: 20px;
    border-radius: 10px;
    width: 80%;
    max-width: 600px;
    box-shadow: 0 4px 10px rgba(0, 0, 0, 0.3);
    transition: transform 0.3s ease, background-color 0.3s ease;
    cursor: pointer;
    position: relative;
}

.event:hover {
    background-color: #3a3a5e;
    transform: translateY(-5px);
}

.date {
    font-size: 1.5em;
    font-weight: bold;
    margin-bottom: 10px;
    color: #f39c12;
}

.description {
    font-size: 1.2em;
    color: #bdc3c7;
}

#event-details {
    margin-top: 40px;
    background-color: #282846;
    padding: 20px;
    border-radius: 10px;
    box-shadow: 0 4px 10px rgba(0, 0, 0, 0.3);
    width: 80%;
    max-width: 600px;
    text-align: left;
    font-size: 1.1em;
    line-height: 1.6;
}

#event-details p {
    margin: 0;
    color: #bdc3c7;
}

