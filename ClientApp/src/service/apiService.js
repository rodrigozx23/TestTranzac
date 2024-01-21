export const insertpresent = async ({ datetime }) => {
    try {
        const response = await fetch('https://localhost:7154/Clock/createTimer', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json',
            },
            body: JSON.stringify({ id: "0", Time: datetime }),
        });

        if (response.ok) {
            const data = await response.json();
            return data;
        } else {

            const errorData = await response.json(); 
            throw new Error('Failed to insert Timer: ${errorData.message}');
        }
    } catch (error) {
        throw new Error('Network error: ${error.message}');
    }
};

export const insertpresent2 = async (form) => {
    try {
        const response = await fetch('https://localhost:7154/Clock/presets', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json',
            },
            body: JSON.stringify(form),
        });

        if (response.ok) {
            const data = await response.json();
            return data;
        } else {

            const errorData = await response.json();
            throw new Error('Failed to insert Timer: ${errorData.message}');
        }
    } catch (error) {
        throw new Error('Network error: ${error.message}');
    }
};