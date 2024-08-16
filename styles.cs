body {
    background-color: #121212;
    color: #fff;
    font-family: Arial, sans-serif;
    margin: 0;
    padding: 20px;
    display: flex;
    justify-content: center;
    align-items: center;
    height: 100vh;
}

.timeline {
    width: 80%;
    max-width: 800px;
}

h1 {
    text-align: center;
    margin-bottom: 20px;
}

.timeline-events {
    display: flex;
    flex-direction: column;
    gap: 10px;
}

.event {
    background-color: #333;
    padding: 10px;
    border-radius: 5px;
    cursor: pointer;
    text-align: center;
    position: relative;
}

.event:hover {
    background-color: #555;
}

.date {
    font-size: 1.2em;
    font-weight: bold;
}

.description {
    font-size: 1.1em;
    margin-top: 5px;
}

#event-details {
    margin-top: 20px;
    padding: 10px;
    background-color: #222;
    border-radius: 5px;
    text-align: center;
}
