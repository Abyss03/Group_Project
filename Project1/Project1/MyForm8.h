#pragma once
#include "MyForm9.h"

namespace Project1 {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// MyForm8 ���K�n
	/// </summary>
	public ref class MyForm8 : public System::Windows::Forms::Form
	{
	public:
		MyForm8(void)
		{
			InitializeComponent();
			//
			//TODO:  �b���[�J�غc�禡�{���X
			//
		}

	protected:
		/// <summary>
		/// �M������ϥΤ����귽�C
		/// </summary>
		~MyForm8()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::Button^  button1;
	protected:

	private:
		/// <summary>
		/// �]�p�u��һݪ��ܼơC
		/// </summary>
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// �����]�p�u��䴩�һݪ���k - �ФŨϥε{���X�s�边
		/// �ק�o�Ӥ�k�����e�C
		/// </summary>
		void InitializeComponent(void)
		{
			System::ComponentModel::ComponentResourceManager^  resources = (gcnew System::ComponentModel::ComponentResourceManager(MyForm8::typeid));
			this->button1 = (gcnew System::Windows::Forms::Button());
			this->SuspendLayout();
			// 
			// button1
			// 
			this->button1->Location = System::Drawing::Point(727, 614);
			this->button1->Name = L"button1";
			this->button1->Size = System::Drawing::Size(45, 35);
			this->button1->TabIndex = 0;
			this->button1->Text = L"NEXT";
			this->button1->UseVisualStyleBackColor = true;
			this->button1->Click += gcnew System::EventHandler(this, &MyForm8::button1_Click);
			// 
			// MyForm8
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 12);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->BackgroundImage = (cli::safe_cast<System::Drawing::Image^>(resources->GetObject(L"$this.BackgroundImage")));
			this->BackgroundImageLayout = System::Windows::Forms::ImageLayout::Stretch;
			this->ClientSize = System::Drawing::Size(784, 661);
			this->Controls->Add(this->button1);
			this->Name = L"MyForm8";
			this->Text = L"MyForm8";
			this->ResumeLayout(false);

		}
#pragma endregion
	private: System::Void button1_Click(System::Object^  sender, System::EventArgs^  e) {
		this->Hide();
		MyForm9 ^ form9 = gcnew MyForm9;
		form9->Show();
	}
	};
}
