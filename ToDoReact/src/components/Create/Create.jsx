import React from 'react'

import './Create.scss'

const Create = () => {
	const [title, setTitle] = React.useState('')
	const [description, setDescription] = React.useState('')
	const [deadline, setDeadline] = React.useState('')

	const handleSubmit = async event => {
		event.preventDefault()

		const newTask = {
			title,
			description,
			startTime: new Date().toISOString(),
			status: 1,
			deadline,
		}

		try {
			const response = await fetch('http://localhost:5149/Tasks', {
				method: 'POST',
				headers: {
					'Content-Type': 'application/json',
				},
				body: JSON.stringify(newTask),
			})

			if (!response.ok) {
				throw new Error('Не удалось создать задачу')
			}

			setTitle('')
			setDescription('')
			setDeadline('')
		} catch (error) {
			console.error('Ошибка при создании задачи:', error)
		}
	}
	return (
		<div className='create__block'>
			<form className='create__form' onSubmit={handleSubmit}>
				<div>
					<label htmlFor='title'>Название:</label>
					<input
						type='text'
						id='title'
						value={title}
						onChange={e => setTitle(e.target.value)}
						required
					/>
				</div>
				<div>
					<label htmlFor='description'>Описание:</label>
					<textarea
						id='description'
						value={description}
						onChange={e => setDescription(e.target.value)}
						required
					></textarea>
				</div>
				<div>
					<label htmlFor='deadline'>Дедлайн:</label>
					<input
						type='datetime-local'
						id='deadline'
						value={deadline}
						onChange={e => setDeadline(e.target.value)}
						required
					/>
				</div>
				<button type='submit'>Создать задачу</button>
			</form>
		</div>
	)
}

export default Create
