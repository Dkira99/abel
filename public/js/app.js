document.addEventListener('DOMContentLoaded', () => {
    // Referencias a enlaces de navegación
    const navLinks = document.querySelectorAll('.nav-link');
    const contentArea = document.getElementById('content-area');

    // Contenido para cada sección
    const contents = {
        enlazada: {
            title: 'Lista Enlazada',
            description: 'Una lista enlazada es una estructura de datos donde cada nodo apunta al siguiente. Los nodos se almacenan en ubicaciones no contiguas.',
            image: 'images/lista-enlazada.png',
            output: '1 -> 2 -> 3 -> null'
        },
        doble: {
            title: 'Lista Doble Enlazada',
            description: 'Una lista doble enlazada tiene punteros hacia adelante y hacia atrás, lo que permite la navegación en ambas direcciones.',
            image: 'images/lista-doble.png',
            output: '1 <-> 2 <-> 3 <-> null'
        },
        circular: {
            title: 'Lista Circular Enlazada',
            description: 'En una lista circular, el último nodo apunta al primero, creando un ciclo cerrado de nodos.',
            image: 'images/lista-circular.png',
            output: '1 -> 2 -> 3 -> 1 -> 2 -> 3 -> ...'
        }
    };

    // Función para actualizar el contenido dinámicamente
    const updateContent = (section) => {
        const { title, description, image, output } = contents[section];
        contentArea.innerHTML = `
            <h2>${title}</h2>
            <p>${description}</p>
            <img src="${image}" alt="${title}" style="width: 80%; height: auto; border-radius: 5px;">
            <p class="example-output">${output}</p>
        `;
    };

    // Evento al hacer clic en los enlaces de navegación
    navLinks.forEach(link => {
        link.addEventListener('click', (e) => {
            e.preventDefault();
            const section = e.target.getAttribute('href').substring(1);
            updateContent(section);
        });
    });
});
